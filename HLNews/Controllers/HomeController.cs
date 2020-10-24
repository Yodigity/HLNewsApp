using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using HLNewsLibrary.API;
using Microsoft.Extensions.Configuration;
using HLNews.Models;

namespace HLNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        /* public IActionResult Index()
         {

             //ResultsController results = new ResultsController(_config);

             NewsEndpoint newsEndpoint = new NewsEndpoint();
             var articles = newsEndpoint.Get();
             return View(articles);
         }*/

        public IActionResult Index(String searchString)
        {
            List<string> languageList = new List<string>{"ae", "ar", "at", "au", "be", "bg", "br", "ca", "ch", "cn",
             "co", "cu", "cz", "de", "eg", "fr", "gb", "gr", "hk", "hu", "id", "ie", "il",
             "in", "it", "jp", "kr", "lt", "lv", "ma", "mx", "my", "ng",
             "nl", "no", "nz", "ph", "pl", "pt", "ro", "rs", "ru", "sa", "se", "sg", "si", "sk", "th", "tr", "tw",
             "ua", "us", "ve", "za" };
            //ResultsController results = new ResultsController(_config);

            ViewData["Languages"] = languageList;
            NewsEndpoint newsEndpoint = new NewsEndpoint();
            var articles = newsEndpoint.Get(searchString);
            return View(articles);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
