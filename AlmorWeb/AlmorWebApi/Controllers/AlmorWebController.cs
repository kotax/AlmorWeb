using AlmorAPI.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlmorWebApi.Controllers
{
    public class AlmorWebController : Controller
    {
        // GET: AlmorWeb
        //public ActionResult Index()
        //{
        //    return View();
        //}
       
        public ActionResult Overview()
        {
            return View();
        }

        public ActionResult Ranking()
        {

            return View();
        }

    }
}