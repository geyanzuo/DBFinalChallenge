using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class OrderController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Orders102146016> Get()
        {
            DADModel dBmodel = new DADModel();
            return dBmodel.Orders102146016.ToList();
        }

        // GET api/<controller>/5
        public Orders102146016 Get(int id)
        {
            DADModel dBmodel = new DADModel();
            return dBmodel.Orders102146016.FirstOrDefault(o =>o.CustomerNo== id);
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