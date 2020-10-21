﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HLNews.Models;
using Microsoft.AspNetCore.Mvc;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HLNews.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {

        
        // GET: api/<ResultsController>
        [HttpGet]
        public List<ArticleModel> Get()
        {
            List<ArticleModel> articles = new List<ArticleModel>();
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                Q = "Apple",
                
                Language = Languages.EN,
               
            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                // total results found
                var data = articlesResponse.TotalResults;
                Console.WriteLine();
                // here's the first 20
                foreach (var article in articlesResponse.Articles)
                {

                    ArticleModel newArticle = new ArticleModel
                    {
                        
                        Title = article.Title,
                        description = article.Description,
                        author = article.Author,
                        url = article.Url,
                        publishedAt = (DateTime)article.PublishedAt
                    };

                    articles.Add(newArticle);
                   /* // title
                    Console.WriteLine(article.Title);
                    // author
                    Console.WriteLine(article.Author);
                    // description
                    Console.WriteLine(article.Description);
                    // url
                    Console.WriteLine(article.Url);
                    // published at
                    Console.WriteLine(article.PublishedAt);*/
                }
            }
            return articles;
            //return new string[] { "value1", "value2" };
        }

        // GET api/<ResultsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ResultsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ResultsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ResultsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}