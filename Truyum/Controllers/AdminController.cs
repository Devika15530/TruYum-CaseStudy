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
    public class AdminController : Controller
    {
        AdminRepository adminObject = new AdminRepository();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewItem()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNewItem(Items item)
        {
            if (ModelState.IsValid)
            {
                adminObject.AddItem(item);
                return RedirectToAction("GetAllItems");
            }
            return View(item);
        }
        [HttpGet]
        public IActionResult GetAllItems()
        {
            List<Items> lstItems = new List<Items>();
            lstItems = adminObject.GetAllItems().ToList();

            return View(lstItems);
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            Items item = adminObject.GetItemById(id);
            return View(item);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Items item)
        {
            if (ModelState.IsValid)
            {
                adminObject.UpdateItem(item);
                return RedirectToAction("GetAllItems");
            }
            return View(item);
        }

        [HttpGet]
        public IActionResult GetItem(int? id)
        {
            Items item = adminObject.GetItemById(id);
            return View(item);
        }
        



        [HttpGet]
        public IActionResult DeleteItem(int? id)
        {
            Items item = adminObject.GetItemById(id);

            return View(item);
        }

        [HttpPost, ActionName("DeleteItem")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteItem(int id)
        {
            adminObject.DeleteItem(id);
            return RedirectToAction("GetAllItems");
        }
    }
}