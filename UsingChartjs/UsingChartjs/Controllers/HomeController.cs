using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsingChartjs.Models;

namespace UsingChartjs.Controllers
{
    public class HomeController : Controller
    {
        ABC_Company_DBEntities _dbContext = new ABC_Company_DBEntities();
        public ActionResult Index()
        {
            var result = _dbContext.EmpDetails.Select(x=>x.Developer_Name).ToList();
            var result2 = _dbContext.EmpDetails.Select(x=>x.Salary).ToList();

            ViewBag.result = result;
            ViewBag.result2 = result2;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetChartData()
        {
            var result = _dbContext.EmpDetails.ToList();
            var result2 = _dbContext.EmpDetails.ToList();

            ViewBag.result = result;
            ViewBag.result2 = result2;


            return null;
        }

        public class devsal
        {
            public int Developer1 { get; set; }
            public int Developer2 { get; set; }
        }
    }
}