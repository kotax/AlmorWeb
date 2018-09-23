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
        //[Route("/api/login")]
        [ActionName("login")]
        public HttpResponseMessage GetUserByName(String username, String password)
        {
            
            try
            {
                User us = _contex.Users.Include("UserGoals.Goal").Include("UserAchievements.Achievement").Where(u => u.Username == username && u.Password == password).FirstOrDefault();
                return Request.CreateResponse<User>(HttpStatusCode.OK, us);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            
        }

        [HttpGet]
        //[Route("/api/login")]
        [ActionName("goals")]
        public HttpResponseMessage GetGoals()
        {

            try
            {
                IList<Goal> goals = _contex.Goals.ToList();
                return Request.CreateResponse<IList<Goal>>(HttpStatusCode.OK, goals);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }

        }

        [HttpPost]
        [ActionName("singup")]
        public HttpResponseMessage CreateUser(User us)
        {
           
            try
            {
                _contex.Users.Add(us);
                _contex.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);   
            }
           
        }
    }
}
