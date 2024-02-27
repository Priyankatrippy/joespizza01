using System;
using System.Web.Mvc;
using JoesPizzaPortal.Models;

namespace JoesPizzaPortal.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza/Selection
        public ActionResult Selection()
        {
            return View();
        }

        // POST: Pizza/Order
        [HttpPost]
        public ActionResult Order(PizzaSelection model)
        {
            // Logic to process the order
            // For demonstration purposes, let's just redirect to a confirmation page
            return RedirectToAction("Confirmation", new { pizzaType = model.PizzaType, quantity = model.Quantity });
        }

        // GET: Pizza/Confirmation
        public ActionResult Confirmation(int pizzaType, int quantity)
        {
            // Here you can display a confirmation message or further process the order
            ViewData["PizzaType"] = pizzaType;
            ViewData["Quantity"] = quantity;
            return View();
        }
    }
}
