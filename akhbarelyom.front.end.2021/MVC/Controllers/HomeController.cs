using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MVC.Data;
using MVC.Models;
using MVC.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDAL _dal;

        public HomeController(ILogger<HomeController> logger, IDAL dal)
        {
            _logger = logger;
            _dal = dal;
        }

        public IActionResult Index()
        {
            var s = _dal.GetHome().HomeLatestNews;
            var M = _dal.GetHome().Slider;

            return View(M);
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
