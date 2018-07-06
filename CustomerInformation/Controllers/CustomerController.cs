using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerDAL;
using CustomerEntity;

namespace CustomerInformation.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerDataAccess customer = DataAccessFactory.GetCustomerDataAccess();
        // GET: Customer
        public ActionResult Index()
        {
            return View(customer.GetAll().ToList());
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            Customer objCustomer = new Customer();
            objCustomer.Name = collection["Name"].ToString();
            objCustomer.Address = collection["Address"].ToString();
            objCustomer.City = collection["City"].ToString();
            objCustomer.Sex = collection["Sex"].ToString();
            objCustomer.Religion = collection["Religion"].ToString();
            objCustomer.BirthDate = Convert.ToDateTime(collection["BirthDate"]);

            customer.Insert(objCustomer);
            return View(customer.GetAll().ToList());
        }
    }
}