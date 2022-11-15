using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class LoginController : ApiController
    {
        public DBModel db = new DBModel();

        //api/getname
        public IQueryable<Login> getLogin()
        {
            return db.Login;
        }
    }
}
