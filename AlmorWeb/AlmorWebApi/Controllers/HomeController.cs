using AlmorAPI.Models;
using AlmorAPI.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlmorWebApi.Controllers
{
    public class HomeController : Controller
    {
        OracleDbContext _contex = new OracleDbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(String username, String password)
        {
            try{
                User us = _contex.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();//.Include("UserGoals.Goal").Include("UserAchievements.Achievement").Where(u => u.Username == username && u.Password == password).FirstOrDefault();
                if(us != null)
                {
                    return Redirect("/AlmorWeb/Overview");
                }
            }
            catch (Exception e)
            {

            }
            return RedirectToAction("/");
        }
    }
}