using HLNews.Models;
using Microsoft.Extensions.Configuration;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HLNewsLibrary.API
{
    public class NewsEndpoint
    {
        

        public NewsEndpoint()
        {
          
        }


        private Countries GetCountry(string country)
        {
            switch (country)
            {
                case "ae":
                    return Countries.AE;
                    
                case "ar":
                    return Countries.AR;
                case "at":
                    return Countries.AT;
                case "au":
                    return Countries.AU;
                case "be":
                    return Countries.BE;
                case "bg":
                    return Countries.BG;
                case "br":
                    return Countries.BR;
                case "ca":
                    return Countries.CA;
                case "ch":
                    return Countries.CH;
                case "cn":
                    return Countries.CN;
                case "co":
                    return Countries.CO;
        
                case "cu":
                    return Countries.CU;
                case "cz":
                    return Countries.CZ;

                case "de":
                    return Countries.DE;
                case "eg":
                    return Countries.EG;
                case "fr":
                    return Countries.FR;
                case "gb":
                    return Countries.GB;
                case "gr":
                    return Countries.GR;
                case "hk":
                    return Countries.HK;
                case "hu":
                    return Countries.HU;
                case "id":
                    return Countries.ID;
                case "ie":
                    return Countries.IE;
                case "il":
                    return Countries.IL;
                case "in":
                    return Countries.IN;
                case "it":
                    return Countries.IT;
                case "jp":
                    return Countries.JP;
                case "kr":
                    return Countries.KR;
                case "lt":
                    return Countries.LT;
                case "lv":
                    return Countries.LV;
                case "ma":
                    return Countries.MA;
                case "mx":
                    return Countries.MX;
                case "my":
                    return Countries.MY;
                case "ng":
                    return Countries.NG;
                case "nl":
                    return Countries.NL;

                case "no":
                    return Countries.NO;
                case "nz":
                    return Countries.NZ;
                case "ph":
                    return Countries.PH;
                case "pl":
                    return Countries.PL;
                case "pt":
                    return Countries.PT;
                case "ro":
                    return Countries.RO;
                case "rs":
                    return Countries.RS;
                case "ru":
                    return Countries.RU;
                case "sa":
                    return Countries.SA;
                case "se":
                    return Countries.SE;
                case "sg":
                    return Countries.SG;
                case "si":
                    return Countries.SI;
                case "sk":
                    return Countries.SK;
                case "th":
                    return Countries.TH;
                case "tr":
                    return Countries.TR;
                case "tw":
                    return Countries.TW;
                case "ua":
                    return Countries.UA;
                case "us":
                    return Countries.US;
                case "ve":
                    return Countries.VE;
                case "za":
                    return Countries.ZA;
                default:
                    return Countries.US;


            }
        }

        public List<ArticleModel> Get(String searchString= "Apple", String country = "us")
        {
            NewsApiClient newsApiClient = new NewsApiClient(HLNewsLibrary.Properties.Resources.NewsAPIKey);
            List<ArticleModel> articles = new List<ArticleModel>();
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                Q = searchString,
                Country = GetCountry(country),
                Language = Languages.EN,


            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                // total results found
                var data = articlesResponse.TotalResults;

                if (articlesResponse.Articles.Count > 0)
                {
                    // here's the first 20
                    foreach (var article in articlesResponse.Articles)
                    {

                        ArticleModel newArticle = new ArticleModel
                        {
                            sourceId = article.Source.Id,
                            title = article.Title,
                            description = article.Description,
                            author = article.Author,
                            url = article.Url,
                            imageURL = article.UrlToImage,
                            publishedAt = (DateTime)article.PublishedAt
                        };

                        articles.Add(newArticle);

                    }
                    
                }
                else
                {
                    ArticleModel newArticle = new ArticleModel
                    {
                        sourceId = "No Data Available",
                        title = "No Data Available",
                        description = "No Data Available",
                        author = "No Data Available",
                        url = "No Data Available",
                       

                    };
                    articles.Add(newArticle);
                }

            }
           
            return articles;

        }
    }
}
