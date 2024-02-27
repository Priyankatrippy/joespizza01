using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoesPizzaPortal.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Order/Checkout
        public ActionResult Checkout(string pizzaType, int quantity)
        {
            ViewBag.PizzaType = pizzaType;
            ViewBag.Quantity = quantity;
            // Add logic to retrieve pricing and other checkout details
            return View();
        }

        // POST: /Order/Confirmation
        [HttpPost]
        public ActionResult Confirmation(FormCollection form)
        {
            // Add logic to process the order and generate an order ID
            // For demonstration purposes, let's generate a mock order ID
            string orderId = GenerateOrderId();
            ViewBag.OrderId = orderId;
            ViewBag.PizzaType = form["pizzaType"];
            // Add more confirmation details here
            return View();
        }

        // Method to generate mock order ID (replace with actual logic)
        private string GenerateOrderId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
