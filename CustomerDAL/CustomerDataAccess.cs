using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerEntity;

namespace CustomerDAL
{
    class CustomerDataAccess : ICustomerDataAccess
    {
        private CustomerDBContext context;
        public CustomerDataAccess(CustomerDBContext context)
        {
            this.context = context;
        }

        public Customer Get(int id)
        {
            return this.context.Customers.SingleOrDefault(x => x.CustomerId == id);
            //throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            return this.context.Customers.ToList();
            //throw new NotImplementedException();
        }

        public int Insert(Customer customer)
        {
            this.context.Customers.Add(customer);
            return this.context.SaveChanges();
            //throw new NotImplementedException();
        }

        public int Update(Customer customer)
        {
            Customer objCustomer = this.context.Customers.SingleOrDefault(a => a.CustomerId == customer.CustomerId);
            objCustomer.Name = customer.Name;
            objCustomer.Address = customer.Address;
            objCustomer.City = customer.City;
            objCustomer.Religion = customer.Religion;
            objCustomer.Sex = customer.Sex;
            objCustomer.BirthDate = customer.BirthDate;
            return this.context.SaveChanges();
            //throw new NotImplementedException();
        }
        public int Delete(int id)
        {
            Customer customer = this.context.Customers.SingleOrDefault(x => x.CustomerId == id);
            this.context.Customers.Remove(customer);

            return this.context.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
