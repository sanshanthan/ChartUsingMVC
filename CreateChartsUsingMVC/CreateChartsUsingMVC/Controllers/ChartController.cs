using CreateChartsUsingMVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace CreateChartsUsingMVC.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult column()
        {
            var _context = new ABC_Company_DBEntities2();
            ArrayList xData = new ArrayList();
            ArrayList yData = new ArrayList();

            var result = (from c in _context.EmpDetails
                          select c);

            result.ToList().ForEach(rs=>xData.Add(rs.Developer_Name));
            result.ToList().ForEach(rs => yData.Add(rs.Salary));

            new Chart(width: 600, height: 400, theme: ChartTheme.Vanilla3D)
                .AddTitle("Chart for Growth [Column Chart]")
                .AddSeries("Default", chartType: "column", xValue: xData, yValues: yData)
          .Write("bmp");
            return null;
        }

        public ActionResult Doughnut()
        {
            var _context = new ABC_Company_DBEntities2();
            ArrayList xData = new ArrayList();
            ArrayList yData = new ArrayList();

            var result = (from c in _context.EmpDetails
                          select c);

            result.ToList().ForEach(rs => xData.Add(rs.Developer_Name));
            result.ToList().ForEach(rs => yData.Add(rs.Salary));

            new Chart(width: 600, height: 400, theme: ChartTheme.Vanilla3D)
                .AddTitle("Chart for Growth [Column Chart]")
                .AddSeries("Default", chartType: "Doughnut", xValue: xData, yValues: yData)
          .Write("bmp");
            return null;
        }
    }
}
