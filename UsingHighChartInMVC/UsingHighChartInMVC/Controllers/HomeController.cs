using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsingHighChartInMVC.Models;

namespace UsingHighChartInMVC.Controllers
{
    public class HomeController : Controller
    {
        ABC_Company_DBEntities _dbContext = new ABC_Company_DBEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult GetChartData()
        {
            int result = _dbContext.EmpDetails.FirstOrDefault(x=>x.Developer_Name== "Developer 1").Salary.Value;
            int result2 = _dbContext.EmpDetails.FirstOrDefault(x => x.Developer_Name == "Developer 2").Salary.Value;
            devsal ds = new devsal();
            ds.Developer1 = result;
            ds.Developer2 = result2;
            return Json(ds, JsonRequestBehavior.AllowGet);
        }

        public class devsal
        {
            public int Developer1 { get; set; }
            public int Developer2 { get; set; }
        }
    }
}