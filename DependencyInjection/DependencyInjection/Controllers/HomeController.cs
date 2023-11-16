using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Models
{
    public class HomeController : Controller
    {
        private IEmployee _employee;

        public HomeController(IEmployee employee)
        { 
            _employee = employee;
        }
        public string Index()
        {
         return   _employee.GetEmployee(1).Name;
        }
    }
}