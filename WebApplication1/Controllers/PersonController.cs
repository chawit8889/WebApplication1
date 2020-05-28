using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult InsertPerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertPerson([FromBody]Person person)
        {
            TestContext context = new TestContext();
            context.Person.Add(person);
            context.SaveChanges();
            return Json (person );
        }
    }
}