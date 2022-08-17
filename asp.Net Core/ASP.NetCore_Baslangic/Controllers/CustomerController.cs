using ASP.NetCore_Baslangic.Entities;
using ASP.NetCore_Baslangic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCore_Baslangic.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index3()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer {Id=1, FirstName = "Yunus", LastName = "Emre", City="İstanbul"},
                new Customer {Id=2, FirstName = "Yunus", LastName = "Emre", City="İstanbul"},
                new Customer {Id=3, FirstName = "Yunus", LastName = "Emre", City = "İstanbul"}

        };
            List<string> shops = new List<string> { "Ankara", "İstanbul", "İzmir" };

            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops,

            };
            return View(model);
        }


        [HttpGet]  // listeleme işlemleri için get kullanılır
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel 
            { 
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text = "Ankara", Value = "06"},
                    new SelectListItem{Text = "İstanbul", Value = "34"},
                    new SelectListItem{Text = "İzmir", Value = "35"}
                }
            });
        }

        [HttpPost] // ekleme silme güncelleme işlemleri yapılır
        public string SaveCustomer(Customer customer)
        {
            return "Kaydedildi";
        }
    }

}
