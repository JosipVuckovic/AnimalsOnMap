using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AnimalsOnMap.Models;
using System.Threading;
using System.Globalization;
using AnimalsOnMap.Data.Interfaces;
using AnimalsOnMap.Data.Classes;

namespace AnimalsOnMap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAnimalManager _manager;
        

        public HomeController(ILogger<HomeController> logger, IAnimalManager manager)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            _logger = logger;
            _manager = manager;
        }

        public IActionResult Index()
        {
            var grpByPec = _manager.GetAllAnimals();
            return View(grpByPec);
        }      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
