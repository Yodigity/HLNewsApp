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
using HLNews.Helpers;

namespace HLNews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;
        private readonly INewsEndpoint _newsEndpoint;

        public HomeController(ILogger<HomeController> logger, IConfiguration config, INewsEndpoint newsEndpoint)
        {
            _logger = logger;
            _config = config;
            _newsEndpoint = newsEndpoint;
            
        }

        /* public IActionResult Index()
         {

             //ResultsController results = new ResultsController(_config);

             NewsEndpoint newsEndpoint = new NewsEndpoint();
             var articles = newsEndpoint.Get();
             return View(articles);
         }*/

        public IActionResult Index(String searchString, string country)
        {
            List<string> countryList = CountryList.countryDisplayList();
            //ResultsController results = new ResultsController(_config);

            ViewData["Countries"] = countryList;
            if (country != null)
            {
                ViewData["SelectedCountry"] = country;
            }
        
            var articles = _newsEndpoint.Get(searchString, country);
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
