using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class NorthwindController : Controller
    {
        private string _connectionString = @"Data Source=.\sqlexpress;Initial Catalog=Northwnd; Integrated Security=true;";

        public ActionResult Index()
        {
            NorthwindManager mgr = new NorthwindManager(_connectionString);
            NorthwindViewModel vm = new NorthwindViewModel();
            vm.Products = mgr.GetProducts();
            return View(vm);
        }
    }
}