using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment.Models;

namespace Assignment.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee _employee;

        public HomeController(IEmployee abc)
        {
            _employee = abc;
        }
        public string Index()
        {
            return _employee.GetEmployee(1).Name;
        }
      
    }
}
