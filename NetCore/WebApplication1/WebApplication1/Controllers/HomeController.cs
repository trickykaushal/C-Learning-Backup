using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dependency_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_3.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee employee;

        public HomeController(IEmployee employee)
        {
            this.employee = employee;
        }

        public string Index()
        {
            return employee.getEmployee(1);
           
        }
    }
}