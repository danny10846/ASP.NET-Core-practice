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
        /// <summary>
        /// We can pass an id to the method, so localhost5000.../about/tellmemore/yo, 
        /// yo will be our parameter. null if we don't give it empty string value initially
        /// and don't supply a parameter in the url field
        /// </summary>
        /// <param name="yo">Our id name has to match with our routing map in Startup</param>
        /// <returns></returns>
        public IActionResult TellMeMore(string yo = "") {
            //return new JsonResult(new {name = "TellMeMore", content = moreInfo }); <---- JSON return for API calls etc
            return View();
        }
        
    }
}
