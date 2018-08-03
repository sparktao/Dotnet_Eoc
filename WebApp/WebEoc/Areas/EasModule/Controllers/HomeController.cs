using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.EasModule.Controllers
{
    [Area("EasModule")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}