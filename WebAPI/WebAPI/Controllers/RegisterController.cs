using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class RegisterController : ApiController
    {
        public DBModel db = new DBModel();
        
        //api/getename
        public IQueryable<Register> getRegister()
        {
            return db.Register;
        }
        

    }
}
