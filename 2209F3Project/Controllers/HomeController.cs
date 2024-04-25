using _2209F3Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;


namespace _2209F3Project.Controllers
{
    //[Route("[Controller]")]
    public record Clients(string cname, int phone, string address);

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[Route("[Action]")]
        public IActionResult Index()
        {
            ViewData["companyName"] = "Arpatech";
            ViewData["phone"] = 343232423;

            string[] emps = { "Zahid", "Akmal", "Huzaifa", "Ammar", "Haris", "Owais" };

            ViewData["employees"] = emps;


            ViewBag.projectName = "Content Managment System";
            ViewBag.id = 343;

            string[] equipments = { "Chair", "Desk", "Glass", "Monitor" };
            
            ViewBag.equipments = equipments;

            TempData["department"] = "Accounts Department";
            TempData["department1"] = "HR Department";


            //List<string> clients = new()
            //{
            //    "Arif","Zahid","Asfar","Amjad"
            //};


            List<Clients> client = new List<Clients>()
            {
               new Clients("Zahid",3434,"House 14"),
               new Clients("Arif",324234324,"House 18"),
               new Clients("Haris",3248787,"House 20")

            };




            TempData["clients"] = client;







            return View();
        }

        //[Route("[Action]")]
        //[Route("H")]
        public IActionResult Privacy()
        {
            //TempData.Keep("department1");
            //TempData.Keep("clients");
            return View();
        }
        public IActionResult Contact()
        {
            //TempData.Keep("clients");
            return View("Contact");
        }
        //[Route("[Action]")]
        public IActionResult About()
        {
            return Json(new {name = "usama"});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}