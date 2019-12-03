using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class PerformController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Perform102146016> Get()
        {
            DADModel dBmodel = new DADModel();
            return dBmodel.Perform102146016.ToList();
        }

        // GET api/<controller>/5
        public Perform102146016 Get(string id)
        {
            DADModel dBmodel = new DADModel();
            return dBmodel.Perform102146016.FirstOrDefault(p => p.RecordID == id);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}