using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public ActionResult Index()
        {
            // Örnek veriler
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Product 1", Price = 10.00m, Quantity = 2 },
                new Order { Id = 2, ProductName = "Product 2", Price = 20.00m, Quantity = 1 },
                new Order { Id = 3, ProductName = "Product 3", Price = 15.50m, Quantity = 5 }
            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}
