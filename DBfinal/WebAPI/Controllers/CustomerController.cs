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
       

        // GET api/<controller>
        public IEnumerable<Customers102146016> Get()
        {

            string query = "Select * from Customer102146016";
            SqlCommand command = new SqlCommand(query);
            SqlDataReader result = command.ExecuteReader();
            List<Customers102146016> customer = new List<Customers102146016>();

            while (result.Read())
            {
                customer.Add(new Customers102146016(int.Parse(result[0].ToString()), result[1].ToString(), result[2].ToString, int.Parse(result[0].ToString())));
            }
            return customer;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
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