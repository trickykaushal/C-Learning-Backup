using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RevisionTill18.Models;
using RevisionTill18.ViewModels;

namespace RevisionTill18.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee _employee;

        public HomeController(IEmployee employee)
        {
            _employee = new MockEmployee();
        }
        public ViewResult Index()
        {
    
            return View(_employee.GetAllEmployee());
        }

        public ViewResult Details(int id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                employee = _employee.GetEmployee(id),
                Pagetitle = "THis is the page title from ViewModel"

            }; 

            //Employee emp = _employee.GetEmployee(id);
            //ViewBag.PageTitle = "Details Page Title";
            //ViewData["emp"] = emp;

            //always  try to use strongly typed view  by using @model directive and avoid ViewData[""] and viewbag


            // we create viewModel when we want to pass extra property added to class


            //wheen we want to use it as a nd api we can pass as Object and in accept: Application/xml

            return View(homeDetailsViewModel);
        }


        public ViewResult LayoutCheck()
        {

            return View(_employee.GetAllEmployee());
        }
    }
}