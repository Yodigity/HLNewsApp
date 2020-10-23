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

            //ResultsController results = new ResultsController(_config);

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
