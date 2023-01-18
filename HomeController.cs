using FirstProject1.DB_Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstProject1.Models;
namespace FirstProject1.Controllers
{
    public class HomeController : Controller
    {
        //-------------For read the data------------------
        public ActionResult Index()
        {
            BDEntities DB = new BDEntities();
            var Empres = DB.emps.ToList();

            List<EmpModle> obj = new List<EmpModle>();

            foreach (var item in Empres)
            {
                obj.Add(new EmpModle()
                {
                    eNo = item.eNo,
                    eName = item.eName,
                    eSal = item.eSal,
                    eDep = item.eDep,
                    eAge = item.eAge,
                    eAdhar=item.eAdhar
                });
            }

            return View(obj);
        }


    //---------Delet the table of Dtabase----------------
        public ActionResult Delete(int eNo)
        {
            BDEntities DB = new BDEntities();

            var deleteitm = DB.emps.Where(a => a.eNo == eNo).First();
            DB.emps.Remove(deleteitm);
            DB.SaveChanges();

            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult AddEmp()
        {
            return View();
        }
        //---------Take form of Input-----------
        [HttpPost]
        public ActionResult AddEmp(EmpModle obj)
        {
            BDEntities DB= new BDEntities();
            emp obj1 = new emp();

            obj1.eName = obj.eName;
            obj1.eSal = obj.eSal;
            obj1.eDep = obj.eDep;
            obj1.eAge = obj.eAge;
            obj1.eAdhar = obj.eAdhar;

            DB.emps.Add(obj1);
            DB.SaveChanges();

            return RedirectToAction("Index");
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
    }
}