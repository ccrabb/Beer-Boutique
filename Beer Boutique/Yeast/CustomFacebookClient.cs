using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using DotNetOpenAuth.AspNet;
using DotNetOpenAuth.AspNet.Clients;
using DotNetOpenAuth.Messaging;
using Newtonsoft.Json;

namespace BeerBoutique.Yeast
{
    public class CustomFacebookClient : OAuth2Client
    {
        //public string ProviderName { get; set; }
        private const string AuthorizationEndpoint = "https://www.facebook.com/dialog/oauth";
       
        private const string TokenEndpoint = "https://graph.facebook.com/oauth/access_token";
        
        private readonly string appId;
        
        private readonly string appSecret;

        public CustomFacebookClient(string appId, string appSecret)
            : base("facebook")
        {
            this.appId = appId;
            this.appSecret = appSecret;
        }

        protected override Uri GetServiceLoginUrl(Uri returnUrl)
        {
            var builder = new UriBuilder("https://www.facebook.com/dialog/oauth");
            var scopeDictionary = new Dictionary<string, string>()
            {
                {
                    "client_id",
                    this.appId
                },
                {
                    "redirect_uri",
                    HttpUtility.UrlEncode(returnUrl.ToString())
                },
                {
                    "scope",
                    "email"
                }
            };
            builder.Query = Helpers.GetQueryString(scopeDictionary);
            return builder.Uri;
        }
        
        protected override IDictionary<string, string> GetUserData(string accessToken)
        {
            var wc = new WebClient();
            var response = wc.DownloadString("https://graph.facebook.com/me?access_token=" + Uri.EscapeDataString(accessToken));
            
            //var facebookGraphData = JsonConvert.DeserializeObject<CustomFacebookGraphData>(response);
            //var dictionary = new Dictionary<string, string>();
            //dictionary.Add("id", facebookGraphData.Id);
            //dictionary.Add("username", facebookGraphData.Email);
            //dictionary.Add("name", facebookGraphData.Name);
            //dictionary.Add("link", facebookGraphData.Link == (Uri)null ? (string)null : facebookGraphData.Link.AbsoluteUri);
            //dictionary.Add("gender", facebookGraphData.Gender);
            //dictionary.Add("birthday", facebookGraphData.Birthday);
            //dictionary.Add("picture", facebookGraphData.Picture);
            //return dictionary;

            return JsonConvert.DeserializeObject<IDictionary<string, object>>(response)
                              .ToDictionary(pair => pair.Key, pair => pair.Value.ToString());
        }

        protected override string QueryAccessToken(Uri returnUrl, string authorizationCode)
        {
            var builder = new UriBuilder("https://graph.facebook.com/oauth/access_token");

            var scopeDictionary = new Dictionary<string, string>()
            {
                {
                    "client_id",
                    this.appId
                },
                {
                    "redirect_uri",
                    NormalizeHexEncoding(returnUrl.AbsoluteUri)
                },
                {
                    "client_secret",
                    this.appSecret
                },
                {
                    "code",
                    authorizationCode
                },
                {
                    "scope",
                    "email"
                }
            };
            builder.Query = Helpers.GetQueryString(scopeDictionary);
            using (WebClient webClient = new WebClient())
            {
                string query = webClient.DownloadString(builder.Uri);
                if (string.IsNullOrEmpty(query))
                    return (string)null;
                else
                    return HttpUtility.ParseQueryString(query)["access_token"];
            }
        }

        /// <summary>
        /// Converts any % encoded values in the URL to uppercase.
        /// 
        /// </summary>
        /// <param name="url">The URL string to normalize</param>
        /// <returns>
        /// The normalized url
        /// </returns>
        /// 
        /// <example>
        /// NormalizeHexEncoding("Login.aspx?ReturnUrl=%2fAccount%2fManage.aspx") returns "Login.aspx?ReturnUrl=%2FAccount%2FManage.aspx"
        /// </example>
        /// 
        /// <remarks>
        /// There is an issue in Facebook whereby it will rejects the redirect_uri value if
        ///             the url contains lowercase % encoded values.
        /// 
        /// </remarks>
        private static string NormalizeHexEncoding(string url)
        {
            char[] chArray = url.ToCharArray();
            for (int index = 0; index < chArray.Length - 2; ++index)
            {
                if ((int)chArray[index] == 37)
                {
                    chArray[index + 1] = char.ToUpperInvariant(chArray[index + 1]);
                    chArray[index + 2] = char.ToUpperInvariant(chArray[index + 2]);
                    index += 2;
                }
            }
            return new string(chArray);
        }
    }
}