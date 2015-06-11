using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TestASPNET5.Models;

namespace TestASPNET5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "ASP.NET 5 Rocks!";
            ViewBag.appName = "测试ASP.NET 5 应用";
            var serverInfo = new ServerInfo
            {
                Name = Environment.MachineName,
                Software = Environment.OSVersion.ToString(),
            };

            return View(serverInfo);
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
