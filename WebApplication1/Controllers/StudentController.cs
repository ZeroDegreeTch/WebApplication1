using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using System.Data.Entity;
namespace WebApplication1.Controllers
{
    public class StudentController : ApiController
    {

        public IHttpActionResult Post([FromBody] Grades g) 
        {
            EFContext ef = new EFContext();

            ef.Entry<Grades>(g).State = EntityState.Added;
            ef.SaveChanges();

            return Ok();
            
        }

    }
}
