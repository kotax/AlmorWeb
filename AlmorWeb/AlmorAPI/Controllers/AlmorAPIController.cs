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
        
        public Usuario GetUserByName(String username, String password)
        {
            try
            {
                Usuario us = _contex.Usuarios.Where(u => u.Username == username).FirstOrDefault();
                return us;
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        [HttpPost]
        [ActionName("singup")]
        public void CreateUser(Usuario us)
        {
            try
            {
                _contex.Usuarios.Add(us);
                _contex.SaveChanges();
            }
            catch(Exception e)
            {
                
            }
           
        }
    }
}
