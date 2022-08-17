using ASP.NetCore_Baslangic.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCore_Baslangic.Models
{
    public class SaveCustomerViewModel
    {
        public Customer Customer { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}
