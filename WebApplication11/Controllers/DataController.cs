using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class DataController : Controller
    {
        public ActionResult Index()
        {
            SimpleViewModel vm = new SimpleViewModel();
            Random rnd = new Random();
            vm.RandomNumber = rnd.Next(1, 1000);

            return View(vm);
        }
    }
}