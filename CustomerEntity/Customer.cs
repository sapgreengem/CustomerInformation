using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEntity
{
    public partial class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Sex { get; set; }
        public string Religion { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
    }
}
