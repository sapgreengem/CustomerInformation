using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CustomerEntity;


namespace CustomerDAL
{
    class CustomerDBContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
