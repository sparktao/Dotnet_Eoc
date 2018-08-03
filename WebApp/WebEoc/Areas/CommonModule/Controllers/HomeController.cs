using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hexagon.Entity;
using Hexagon.IService;
using Hexagon.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.Areas.CommonModule.Controllers
{
    [Area("CommonModule")]
    [Authorize]
    public class HomeController : Controller
    {
        private IConfiguration _configuration;
        private IOrgEmployee empbll;

        public HomeController(IConfiguration Configuration, IOrgEmployee orgEmployeeSvr)
        {
            _configuration = Configuration;
            empbll = orgEmployeeSvr;
        }

        public IActionResult Index()
        {
            ViewData["UserName"] = _configuration.GetSection("AppConfiguration")["CurrentUserName"];
            List<Organization_Employee> emps = empbll.GetEmployeeList();
            ViewData["employee_list"] = emps.Count;

            return View();
        }
    }
}