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
            DADModel dBmodel = new DADModel();
            return dBmodel.Customers102146016.ToList();
        }

        // GET api/<controller>/<CustomerNo>
        public Customers102146016 Get(int id)
        {
            DADModel dBmodel = new DADModel();
            return dBmodel.Customers102146016.FirstOrDefault(c => c.CustomerNo == id);
        }

        
        // POST api/<controller>
        
        public Customers102146016  Post([FromBody] Customer customer)           
        {
            DADModel context = new DADModel();
            
                context.Customers102146016.Add(new Customers102146016()
                {
                    CustomerNo = customer.CustomerNo,
                    CustomerAddress = customer.Address,
                    CustomerName = customer.CustomerName,
                    CustomerPcode = customer.PostCode
                });

                context.SaveChanges();

            return Ok();
            
        }
        
        

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public Customers102146016 Delete(int id)
        {
            DADModel dBmodel = new DADModel();
            return dBmodel.Customers102146016.FirstOrDefault(c => c.CustomerNo == id);
        }
    }
}