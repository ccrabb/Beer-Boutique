

using System;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Yeast.Constants
{
    public enum BeerStyle : int
    {
        [Description("Unknown")]
        Unknown = -1,
        [Description("Classic English-Style Pale Ale")]
        ClassicEnglishStylePaleAle = 1,
        [Description("English-Style India Pale Ale")]
        EnglishStyleIndiaPaleAle = 2,
        [Description("Ordinary Bitter")]
        OrdinaryBitter = 3,
        [Description("Special Bitter or Best Bitter")]
        SpecialBitterorBestBitter = 4,
        [Description("Extra Special Bitter")]
        ExtraSpecialBitter = 5,
        [Description("English-Style Summer Ale")]
        EnglishStyleSummerAle = 6,
        [Description("Scottish-Style Light Ale")]
        ScottishStyleLightAle = 7,
        [Description("Scottish-Style Heavy Ale")]
        ScottishStyleHeavyAle = 8,
        [Description("Scottish-Style Export Ale")]
        ScottishStyleExportAle = 9,
        [Description("English-Style Pale Mild Ale")]
        EnglishStylePaleMildAle = 10,
        [Description("English-Style Dark Mild Ale")]
        EnglishStyleDarkMildAle = 11,
        [Description("English-Style Brown Ale")]
        EnglishStyleBrownAle = 12,
        [Description("Old Ale")]
        OldAle = 13,
        [Description("Strong Ale")]
        StrongAle = 14,
        [Description("Scotch Ale")]
        ScotchAle = 15,
        [Description("British-Style Imperial Stout")]
        BritishStyleImperialStout = 16,
        [Description("British-Style Barley Wine Ale")]
        BritishStyleBarleyWineAle = 17,
        [Description("Robust Porter")]
        RobustPorter = 18,
        [Description("Brown Porter")]
        BrownPorter = 19,
        [Description("Sweet Stout")]
        SweetStout = 20,
        [Description("Oatmeal Stout")]
        OatmealStout = 21,
        [Description("Irish-Style Red Ale")]
        IrishStyleRedAle = 22,
        [Description("Classic Irish-Style Dry Stout")]
        ClassicIrishStyleDryStout = 23,
        [Description("Foreign (Export)-Style Stout")]
        ForeignExportStyleStout = 24,
        [Description("Porter")]
        Porter = 25,
        [Description("American-Style Pale Ale")]
        AmericanStylePaleAle = 26,
        [Description("Fresh Hop Ale")]
        FreshHopAle = 27,
        [Description("Pale American-Belgo-Style Ale")]
        PaleAmericanBelgoStyleAle = 28,
        [Description("Dark American-Belgo-Style Ale")]
        DarkAmericanBelgoStyleAle = 29,
        [Description("American-Style Strong Pale Ale")]
        AmericanStyleStrongPaleAle = 30,
        [Description("American-Style India Pale Ale")]
        AmericanStyleIndiaPaleAle = 31,
        [Description("Imperial or Double India Pale Ale")]
        ImperialorDoubleIndiaPaleAle = 32,
        [Description("American-Style Amber/Red Ale")]
        AmericanStyleAmberRedAle = 33,
        [Description("Imperial or Double Red Ale")]
        ImperialorDoubleRedAle = 34,
        [Description("American-Style Barley Wine Ale")]
        AmericanStyleBarleyWineAle = 35,
        [Description("American-Style Wheat Wine Ale")]
        AmericanStyleWheatWineAle = 36,
        [Description("Golden or Blonde Ale")]
        GoldenorBlondeAle = 37,
        [Description("American-Style Brown Ale")]
        AmericanStyleBrownAle = 38,
        [Description("Smoke Porter")]
        SmokePorter = 39,
        [Description("American-Style Sour Ale")]
        AmericanStyleSourAle = 40,
        [Description("American-Style India Black Ale")]
        AmericanStyleIndiaBlackAle = 41,
        [Description("American-Style Stout")]
        AmericanStyleStout = 42,
        [Description("American-Style Imperial Stout")]
        AmericanStyleImperialStout = 43,
        [Description("Specialty Stouts")]
        SpecialtyStouts = 44,
        [Description("American-Style Imperial Porter")]
        AmericanStyleImperialPorter = 45,
        [Description("German-Style Kolsch")]
        GermanStyleKolsch = 47,
        [Description("Berliner-Style Weisse")]
        BerlinerStyleWeisse = 48,
        [Description("Leipzig-Style Gose")]
        LeipzigStyleGose = 49,
        [Description("South German-Style Hefeweizen")]
        SouthGermanStyleHefeweizen = 50,
        [Description("South German-Style Kristal Weizen")]
        SouthGermanStyleKristalWeizen = 51,
        [Description("German-Style Leichtes Weizen")]
        GermanStyleLeichtesWeizen = 52,
        [Description("South German-Style Bernsteinfarbenes Weizen")]
        SouthGermanStyleBernsteinfarbenesWeizen = 53,
        [Description("South German-Style Dunkel Weizen")]
        SouthGermanStyleDunkelWeizen = 54,
        [Description("South German-Style Weizenbock")]
        SouthGermanStyleWeizenbock = 55,
        [Description("Bamberg-Style Weiss Rauchbier")]
        BambergStyleWeissRauchbier = 56,
        [Description("German-Style Brown Ale/Altbier")]
        GermanStyleBrownAleAltbier = 57,
        [Description("Kellerbier - Ale")]
        KellerbierAle = 58,
        [Description("Belgian-Style Flanders/Oud Bruin")]
        BelgianStyleFlandersOudBruin = 59,
        [Description("Belgian-Style Dubbel")]
        BelgianStyleDubbel = 60,
        [Description("Belgian-Style Tripel")]
        BelgianStyleTripel = 61,
        [Description("Belgian-Style Quadrupel")]
        BelgianStyleQuadrupel = 62,
        [Description("Belgian-Style Blonde Ale")]
        BelgianStyleBlondeAle = 63,
        [Description("Belgian-Style Pale Ale")]
        BelgianStylePaleAle = 64,
        [Description("Belgian-Style Pale Strong Ale")]
        BelgianStylePaleStrongAle = 65,
        [Description("Belgian-Style Dark Strong Ale")]
        BelgianStyleDarkStrongAle = 66,
        [Description("Belgian-Style White")]
        BelgianStyleWhite = 67,
        [Description("Belgian-Style Lambic")]
        BelgianStyleLambic = 68,
        [Description("Belgian-Style Gueuze Lambic")]
        BelgianStyleGueuzeLambic = 69,
        [Description("Belgian-Style Fruit Lambic")]
        BelgianStyleFruitLambic = 70,
        [Description("Belgian-Style Table Beer")]
        BelgianStyleTableBeer = 71,
        [Description("Other Belgian-Style Ales")]
        OtherBelgianStyleAles = 72,
        [Description("French-Style Biere de Garde")]
        FrenchStyleBieredeGarde = 73,
        [Description("French & Belgian-Style Saison")]
        FrenchBelgianStyleSaison = 74,
        [Description("International-Style Pale Ale")]
        InternationalStylePaleAle = 75,
        [Description("Australasian-Style Pale Ale")]
        AustralasianStylePaleAle = 76,
        [Description("German-Style Pilsener")]
        GermanStylePilsener = 77,
        [Description("Bohemian-Style Pilsener")]
        BohemianStylePilsener = 78,
        [Description("European Low-Alcohol Lager")]
        EuropeanLowAlcoholLager = 79,
        [Description("Munchner-Style Helles")]
        MunchnerStyleHelles = 80,
        [Description("Dortmunder/European-Style Export")]
        DortmunderEuropeanStyleExport = 81,
        [Description("Vienna-Style Lager")]
        ViennaStyleLager = 82,
        [Description("German-Style Marzen")]
        GermanStyleMarzen = 83,
        [Description("German-Style Oktoberfest")]
        GermanStyleOktoberfest = 84,
        [Description("European-Style Dark")]
        EuropeanStyleDark = 85,
        [Description("German-Style Schwarzbier")]
        GermanStyleSchwarzbier = 86,
        [Description("Bamberg-Style Marzen")]
        BambergStyleMarzen = 87,
        [Description("Bamberg-Style Helles Rauchbier")]
        BambergStyleHellesRauchbier = 88,
        [Description("Bamberg-Style Bock Rauchbier")]
        BambergStyleBockRauchbier = 89,
        [Description("Traditional German-Style Bock")]
        TraditionalGermanStyleBock = 90,
        [Description("German-Style Heller Bock/Maibock")]
        GermanStyleHellerBockMaibock = 91,
        [Description("German-Style Doppelbock")]
        GermanStyleDoppelbock = 92,
        [Description("German-Style Eisbock")]
        GermanStyleEisbock = 93,
        [Description("Kellerbier - Lager")]
        KellerbierLager = 94,
        [Description("American-Style Lager")]
        AmericanStyleLager = 95,
        [Description("American-Style Light Lager")]
        AmericanStyleLightLager = 96,
        [Description("American-Style Low-Carb Light Lager")]
        AmericanStyleLowCarbLightLager = 97,
        [Description("American-Style Amber Lager")]
        AmericanStyleAmberLager = 98,
        [Description("American-Style Premium Lager")]
        AmericanStylePremiumLager = 99,
        [Description("American-Style Pilsener")]
        AmericanStylePilsener = 100,
        [Description("American-Style Ice Lager")]
        AmericanStyleIceLager = 101,
        [Description("American-Style Malt Liquor")]
        AmericanStyleMaltLiquor = 102,
        [Description("American-Style Marzen/Oktoberfest")]
        AmericanStyleMarzenOktoberfest = 104,
        [Description("American-Style Dark Lager")]
        AmericanStyleDarkLager = 105,
        [Description("Baltic-Style Porter")]
        BalticStylePorter = 106,
        [Description("Australasian-Style Light Lager")]
        AustralasianStyleLightLager = 107,
        [Description("Latin American-Style Light Lager")]
        LatinAmericanStyleLightLager = 108,
        [Description("Tropical-Style Light Lager")]
        TropicalStyleLightLager = 109,
        [Description("International-Style Pilsener")]
        InternationalStylePilsener = 110,
        [Description("Dry Lager")]
        DryLager = 111,
        [Description("Session Beer")]
        SessionBeer = 112,
        [Description("American-Style Cream Ale or Lager")]
        AmericanStyleCreamAleorLager = 113,
        [Description("California Common Beer")]
        CaliforniaCommonBeer = 114,
        [Description("Japanese Sake-Yeast Beer")]
        JapaneseSakeYeastBeer = 115,
        [Description("Light American Wheat Ale or Lager")]
        LightAmericanWheatAleorLager = 116,
        [Description("Fruit Wheat Ale or Lager")]
        FruitWheatAleorLager = 117,
        [Description("Dark American Wheat Ale or Lager")]
        DarkAmericanWheatAleorLager = 118,
        [Description("American Rye Ale or Lager")]
        AmericanRyeAleorLager = 119,
        [Description("German-Style Rye Ale")]
        GermanStyleRyeAle = 120,
        [Description("Fruit Beer")]
        FruitBeer = 121,
        [Description("Field Beer")]
        FieldBeer = 122,
        [Description("Pumpkin Beer")]
        PumpkinBeer = 123,
        [Description("Chocolate/Cocoa-Flavored Beer")]
        ChocolateCocoaFlavoredBeer = 124,
        [Description("Coffee-Flavored Beer")]
        CoffeeFlavoredBeer = 125,
        [Description("Herb and Spice Beer")]
        HerbandSpiceBeer = 126,
        [Description("Specialty Beer")]
        SpecialtyBeer = 127,
        [Description("Specialty Honey Lager or Ale")]
        SpecialtyHoneyLagerorAle = 128,
        [Description("Gluten-Free Beer")]
        GlutenFreeBeer = 129,
        [Description("Smoke Beer")]
        SmokeBeer = 130,
        [Description("Experimental Beer")]
        ExperimentalBeer = 131,
        [Description("Out of Category")]
        OutofCategory = 132,
        [Description("Wood- and Barrel-Aged Beer")]
        WoodandBarrelAgedBeer = 133,
        [Description("Wood- and Barrel-Aged Pale to Amber Beer")]
        WoodandBarrelAgedPaletoAmberBeer = 134,
        [Description("Wood- and Barrel-Aged Dark Beer")]
        WoodandBarrelAgedDarkBeer = 135,
        [Description("Wood- and Barrel-Aged Strong Beer")]
        WoodandBarrelAgedStrongBeer = 136,
        [Description("Wood- and Barrel-Aged Sour Beer")]
        WoodandBarrelAgedSourBeer = 137,
        [Description("Aged Beer")]
        AgedBeer = 138,
        [Description("Other Strong Ale or Lager")]
        OtherStrongAleorLager = 139,
        [Description("Non-Alcoholic Beer")]
        NonAlcoholicBeer = 140,
        [Description("Winter Warmer")]
        WinterWarmer = 141,
    }
}
