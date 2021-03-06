﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using BeerBoutique.Yeast;
using DotNetOpenAuth.AspNet;
using DotNetOpenAuth.AspNet.Clients;
using Microsoft.Web.WebPages.OAuth;

namespace BeerBoutique
{
    public class AuthConfig
    {
        public static void RegisterAuth() {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            //OAuthWebSecurity.RegisterClient(
            //    new CustomFacebookClient(ConfigurationManager.AppSettings["FacebookAppID"], ConfigurationManager.AppSettings["FacebookAppSecret"]), "facebook", null);


            OAuthWebSecurity.RegisterFacebookClient(
                appId: ConfigurationManager.AppSettings["FacebookAppID"],
                appSecret: ConfigurationManager.AppSettings["FacebookAppSecret"]);


            OAuthWebSecurity.RegisterTwitterClient(
                consumerKey: ConfigurationManager.AppSettings["TwitterConsumerKey"],
                consumerSecret: ConfigurationManager.AppSettings["TwitterConsumerSecret"]);

            //OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}