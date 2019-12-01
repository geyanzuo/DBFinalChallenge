using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebAPI.Models
{
    public class ModelFactory
    {
        public Customer Create(Customers102146016 customers)
        {
            return new Customer()
            {
                CustomerNo = customers.CustomerNo,
                CustomerName = customers.CustomerName,
                Address = customers.CustomerAddress,
                PostCode = customers.CustomerPcode,

                Interests =customers.Interests102146016.Select(i =>Create(i)),
                Orders = customers.Orders102146016.Select(o=> Create(o)),
            };
        }

        public Interest Create(Interests102146016 interests)
        {
            return new Interest() 
            {
                InterestCode =interests.InterestCode,
                IntetrestDesc =interests.InterestDesc,
            };

        }

        public Order Create(Orders102146016 order)
        {
            return new Order()
            {
                DateOrdered = order.DateOrder,
                Price = order.Price,
            };

        }

        public Perform Create(Perform102146016 perform)
        {
            return new Perform()
            {
                RecrodID = perform.RecordID,
                Title = perform.Title,
                Performer = perform.Performer,

                Orders = perform.Orders102146016.Select(o => Create(o)),
            };

        }

    }
}