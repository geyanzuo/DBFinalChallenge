using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebAPI.Models
{
    public class QueryCommand
    {
        public IQueryable<Customers102146016> GetCustomers102146016()
        {
            DBModel context = new DBModel();
            return context.Customers102146016;
        }

        public IQueryable<Customers102146016> GetCustomers102146016(int id)
        {
            DBModel context = new DBModel();
            return context.Customers102146016.Where(c=>c.CustomerNo == id).Select(e => e);
        }
    }
}