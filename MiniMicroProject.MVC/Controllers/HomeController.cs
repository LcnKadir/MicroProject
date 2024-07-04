using Microsoft.AspNetCore.Mvc;
using MiniMicroProject.MVC.Models;
using MiniMicroProject.MVC.Services;
using System.Diagnostics;

namespace MiniMicroProject.MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
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
