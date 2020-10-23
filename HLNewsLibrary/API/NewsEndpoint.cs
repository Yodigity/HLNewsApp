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

        
        List<ArticleModel> articles = new List<ArticleModel>();
        public List<ArticleModel> Get(String searchString= "Apple")
        {
            NewsApiClient newsApiClient = new NewsApiClient(HLNewsLibrary.Properties.Resources.NewsAPIKey);
            List<ArticleModel> articles = new List<ArticleModel>();
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                Q = searchString,

                Language = Languages.EN,

            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                // total results found
                var data = articlesResponse.TotalResults;

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
            return articles;

        }
    }
}
