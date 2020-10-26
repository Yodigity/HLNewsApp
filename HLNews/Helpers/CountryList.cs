using NewsAPI.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HLNews.Helpers
{
    public static class CountryList
    {
    /*    public static List<Countries> countryList() { 
            
            return new List<Countries> { Countries.AE , Countries.AR, Countries.AT, Countries.AU, Countries.BE, Countries.BG, Countries.BR, Countries.CA, Countries.CH, Countries.CN,
            Countries.CO, Countries.CU, Countries.CZ, Countries.DE, Countries.EG, Countries.FR, Countries.GB, Countries.GR, Countries.HK, Countries.HU, Countries.ID, Countries.IE, Countries.IL,
            Countries.IN, Countries.IT, "jp", "kr", "lt", "lv", "ma", "mx", "my", "ng",
            "nl", "no", "nz", "ph", "pl", "pt", "ro", "rs", "ru", "sa", "se", "sg", "si", "sk", "th", "tr", "tw",
            "ua", "us", "ve", "za" };
    }*/

        public static List<string> countryDisplayList()
        {

            return new List<string> { "ae", "ar", "at", "au", "be", "bg", "br", "ca", "ch", "cn",
            "co", "cu", "cz", "de", "eg", "fr", "gb", "gr", "hk", "hu", "id", "ie", "il",
            "in", "it", "jp", "kr", "lt", "lv", "ma", "mx", "my", "ng",
            "nl", "no", "nz", "ph", "pl", "pt", "ro", "rs", "ru", "sa", "se", "sg", "si", "sk", "th", "tr", "tw",
            "ua", "us", "ve", "za" };
        }
    }
}
