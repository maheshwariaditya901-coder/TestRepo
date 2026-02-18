    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewEngines;
    using WebApplication1.Models;

namespace WebApplication1.Controllers
    {
        public class ContactController : Controller
        {

            private readonly string email = "contact112@gmail.com";
            private readonly string address = "New Delhi";
            public IActionResult Index()
            {
   
                // both are used for transfering data from controller to view.

                                     //ViewBag
                                     //Dynamic object
                                     //Easier and cleaner syntax
                                     //No type casting needed
                                     //Built on top of ViewData

                ViewData["EmailAddress"] = email;
                ViewBag.Address = address;

                return View();  
            }

            [HttpPost] // this tell the asp.net that run this method when form is submitted
            public IActionResult Index(ContactModel model)
            {
            // here we do  Model Binding.
            ViewData["EmailAddress"] = email;       
                ViewBag.Address = address;

                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                ViewBag.SuccessMessage = "you submitted the form";
                ModelState.Clear();
                return View();
            }
        }
    }
