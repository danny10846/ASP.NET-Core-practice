using Microsoft.AspNetCore.Mvc;
using System;

namespace TestWebsite.Controllers {
    public class HomeController : Controller {
        
        //This function will naturally look at index.cshtml. Won't render just as index.cshtml, as it's a view from MVC. It will first 
        //Look at ViewStart, which will then point us to the layout, which will then express how the view should be rendered.
        public IActionResult Index() {            
            return View();
        }

        public IActionResult Error() {
            return View();
        }
    }
}
