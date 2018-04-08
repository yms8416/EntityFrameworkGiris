using BilgeAdam.Northwind.Bussiness.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Northwind.Bussiness.Context
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("northwindConnStr")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
