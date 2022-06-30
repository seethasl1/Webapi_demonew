using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webapi_demonew.Models;
using Webapi_demonew.Repositories;

namespace Webapi_demonew.Controllers
{
    public class ValuesController : ApiController
    {
        Icomment Icom;
        // GET api/values
        public ValuesController()
        {
            Icom=new Comments();
        }
        //GET api/values
        public IEnumerable<Comment> GetData()
        {
            return Icom.ListofComment();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] Comment Comment)
        {
            Icom.InsertComment(Comment);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
