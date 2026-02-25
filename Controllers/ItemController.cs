using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Overview()
        {
            // making the instance of model
            var Item = new Item() {Name = "ADITYA" };
            return View(Item);
        }

        public IActionResult Edit(int id)
        {
            return Content("id :" + id);
        }
    }
}

//Controller helps to Talks to Model and Returns View.
        