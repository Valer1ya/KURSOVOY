using KursovoyProekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KursovoyProekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.ci = ClassInput.Default();
            ClassOutput co = new ClassOutput();
            co.hsumV = 0;
            co.hsumotVdoR = 0;
            co.hrekfull = 0;
            return View(co);
        }

        [HttpPost]
        public ActionResult Index(ClassInput ci)
        {
            ClassOutput co = new ClassOutput();
            ClassCalc cu = new ClassCalc();
            co = cu.LetsCalc(ci);
            var graphlist = new List<double>() { co.hsumV, co.hsumotVdoR, co.hrekfull };
            ViewBag.graphiclist = Newtonsoft.Json.JsonConvert.SerializeObject(graphlist);
            ViewBag.ci = ci;
            return View(co);
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
