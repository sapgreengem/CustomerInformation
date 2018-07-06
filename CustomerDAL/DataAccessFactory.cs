using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDAL
{
    public abstract class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccess()
        {
            return new CustomerDataAccess(new CustomerDBContext());
        }
    }
}
