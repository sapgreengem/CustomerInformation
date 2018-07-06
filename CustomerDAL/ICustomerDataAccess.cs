﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerEntity;

namespace CustomerDAL
{
    public interface ICustomerDataAccess
    {
        IEnumerable<Customer> GetAll();
        Customer Get(int id);
        int Insert(Customer customer);
        int Update(Customer customer);
        int Delete(int id);
    }
}
