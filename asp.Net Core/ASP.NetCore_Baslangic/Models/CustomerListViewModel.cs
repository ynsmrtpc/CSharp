using ASP.NetCore_Baslangic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCore_Baslangic.Models
{
    public class CustomerListViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<string> Shops { get; set; }
    }
}
