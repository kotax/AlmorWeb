using AlmorAPI.Models;
using AlmorAPI.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AlmorWebApi.Controllers
{
    public class Login
    {
        public String Username { get; set; }
        public String Password { get; set; }
    }
    public class AlmorLoginController : ApiController
    {
        OracleDbContext _contex = new OracleDbContext();

        // POST: api/AlmorLogin
        public HttpResponseMessage Post(Login login)
        {

            try
            {
                User us = _contex.Users.Include("UserGoals.Goal").Include("UserAchievements.Achievement").Where(u => u.Username == login.Username && u.Password == login.Password).FirstOrDefault();
                return Request.CreateResponse<User>(HttpStatusCode.OK, us);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
        }

      
    }
}
