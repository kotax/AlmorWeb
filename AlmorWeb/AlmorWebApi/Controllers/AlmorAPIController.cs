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
    public class Login
    {
        public String Username { get; set; }
        public String Password { get; set; }
    }
    
    public class AlmorAPIController : ApiController
    {
        OracleDbContext _contex = new OracleDbContext();
        

        //[HttpGet]
        //[Route("/api/login")]


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
