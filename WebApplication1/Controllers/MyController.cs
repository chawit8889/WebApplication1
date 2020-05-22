using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MyController : Controller
    {
        public string Index()
        {
            return"Hello My Controller";
        }
        public string HelloWorld(int id,string name)
        {
            return "Hello My Controller"+id+",name"+name;
        }
    }
}