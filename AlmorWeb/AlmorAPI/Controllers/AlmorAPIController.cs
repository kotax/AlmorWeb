using AlmorAPI.Models;
using AlmorAPI.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AlmorAPI.Controllers
{
    
    public class AlmorAPIController : ApiController
    {
        OracleDbContext _contex = new OracleDbContext();

        [HttpGet]
        [ActionName("login")]
        
        public User GetUserByName(String username, String password)
        {
            User us = _contex.Users.Include("UserGoals").Include("UserAchievements").Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            return us;
            try
            {
              
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        [HttpPost]
        [ActionName("singup")]
        public void CreateUser(User us)
        {
            _contex.Users.Add(us);
            _contex.SaveChanges();
            try
            {
               
            }
            catch(Exception e)
            {
                
            }
           
        }
    }
}
