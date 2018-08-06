using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            Task<List<Organization_Employee>> t = empbll.GetEmployeeList();
            t.Wait();
            ViewData["employee_list"] = t.Result.Count;

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetItemById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var item = await empbll.GetEmployeeById(id);
            if (item != null)
            {
                return Ok(item);
            }

            return NotFound();
        }


    }
}