using Microsoft.AspNetCore.Mvc;
using System;

namespace TestWebsite.Controllers {
    public class AboutController : Controller {
        
       /// <summary>
       /// We could now route into website/About and it would break into this code
       /// </summary>
       /// <returns></returns>
        public IActionResult Index() {            
            return View();
        }
        
    }
}
