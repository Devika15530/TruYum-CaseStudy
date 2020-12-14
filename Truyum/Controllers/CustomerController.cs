using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truyum.Models;
using Truyum.Repository;

namespace Truyum.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository customerObject = new CustomerRepository();
        AdminRepository adminObject = new AdminRepository();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetItems()
        {
            List<Items> lstItems = new List<Items>();
            lstItems = adminObject.GetAllItems().ToList();

            return View(lstItems);
        }
        [HttpGet]
        public IActionResult GetItem(int? id)
        {
            Items item = adminObject.GetItemById(id);
            return View(item);
        }
        [HttpGet]
        public IActionResult AddToCart(int? id)
        {
            Items item = customerObject.GetItemById(id);
            customerObject.AddToCart(item);
            return View(item);
        }
        [HttpGet]
        public IActionResult GetCartItems()
        {
            List<Cart> cartList = new List<Cart>();
            cartList = customerObject.GetItemsInCart().ToList();

            return View(cartList);
        }

        [HttpGet]
        public IActionResult DeleteCartItem(int? id)
        {
            Cart cart = customerObject.GetCartItemById(id);

            return View(cart);
        }

        [HttpPost, ActionName("DeleteCartItem")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCartItem(int id)
        {
            customerObject.DeleteItemInCart(id);
            return RedirectToAction("GetCartItems");
        }
    }
}