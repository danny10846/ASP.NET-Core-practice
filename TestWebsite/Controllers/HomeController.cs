using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TestWebsite.Data;

namespace TestWebsite.Controllers {
    public class HomeController : Controller {

        protected ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context) {
            _context = context;
        }

        //This function will naturally look at index.cshtml. Won't render just as index.cshtml, as it's a view from MVC. It will first 
        //Look at ViewStart, which will then point us to the layout, which will then express how the view should be rendered.
        public IActionResult Index() {



            //Make sure we have the database. If not, it creates one using context Config and model creating methods
            _context.Database.EnsureCreated();

            //If we don't have any settings (entries into our DB)
            if (!_context.Settings.Any()) {
                //Add new entry
                _context.Settings.Add(new SettingsDataModel {
                    Id = Guid.NewGuid().ToString(),
                    Name = "BackgroundColor",
                    Value = "Red"
                });

                //This checks the local 'database' list, in memory
                var settingsLocally = _context.Settings.Local.Count();
                //This checks out physical database, Entity makes an actual SQL call and retrieves the output for us.
                //Can check the stack trace of the DB with Profiler, Duration
                var settingsDatabase = _context.Settings.Count();

                var firstLocal = _context.Settings.Local.FirstOrDefault();
                var firstDatabase = _context.Settings.FirstOrDefault();

                //This will do an INSERT command into our DB in the stack trace, and actually update the DB
                _context.SaveChanges();


                settingsLocally = _context.Settings.Local.Count();
                //This will now be 1 rather than 0
                settingsDatabase = _context.Settings.Count();

                firstLocal = _context.Settings.Local.FirstOrDefault();
                firstDatabase = _context.Settings.FirstOrDefault();
            }

            return View();
        }

        public IActionResult Error() {
            return View();
        }
    }
}
