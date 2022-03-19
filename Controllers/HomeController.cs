using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sum.Models;

namespace sum.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Privacy(int a,int b,int c)
        {   
            ViewBag.op1 = a;
            ViewBag.op2 = b;
            var resul = 0;
            
            if(c == 1){
                resul = a + b;
            }else if(c == 2){
                resul = a - b;
            }else if(c == 3){
                resul = a * b;
            }else if(c == 4){
                resul = a / b;
            }

            ViewBag.resul = resul;
            
            return View();
        }
        
        
                

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
