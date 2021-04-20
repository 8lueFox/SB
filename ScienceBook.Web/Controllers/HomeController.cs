using Microsoft.AspNetCore.Mvc;
using ScienceBook.Web.Data;
using ScienceBook.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISBRepository repository;

        public HomeController(ISBRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View(repository.GetUniversitiesWithDepartments());
        }
    }
}
