using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using System.Data.SqlClient;

namespace WebAPI.Controllers
{
    public class CustomerController : ApiController
    {
        ModelFactory modelfactory;

        public CustomerController()
        {
            modelfactory = new ModelFactory();
        }

        // GET api/<controller>
        public IEnumerable<Customer> Get()
        {
            QueryCommand qc = new QueryCommand();
            return qc.GetCustomers102146016().ToList().Select(c=>modelfactory.Create(c));
        }

        // GET api/<controller>/<CustomerNo>
        public Customers102146016 Get(int id)
        {
            using (DBModel model = new DBModel())
            {
                return model.Customers102146016.FirstOrDefault(c => c.CustomerNo == id);
            }
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