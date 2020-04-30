using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebsite.Data;

namespace TestWebsite {
    public class BasicEntityFrameworkCode {
        /// <summary>
        /// Storing old code here
        /// </summary>
        public BasicEntityFrameworkCode() {
            //    using (var context = new ApplicationDbContext()) {

            //        //Make sure we have the database. If not, it creates one using context Config and model creating methods
            //        context.Database.EnsureCreated();

            //        //If we don't have any settings (entries into our DB)
            //        if (!context.Settings.Any()) {
            //            //Add new entry
            //            context.Settings.Add(new SettingsDataModel {
            //                Id = Guid.NewGuid().ToString(),
            //                Name = "BackgroundColor",
            //                Value = "Red"
            //            });

            //            //This checks the local 'database' list, in memory
            //            var settingsLocally = context.Settings.Local.Count();
            //            //This checks out physical database, Entity makes an actual SQL call and retrieves the output for us.
            //            //Can check the stack trace of the DB with Profiler, Duration
            //            var settingsDatabase = context.Settings.Count();

            //            var firstLocal = context.Settings.Local.FirstOrDefault();
            //            var firstDatabase = context.Settings.FirstOrDefault();

            //            //This will do an INSERT command into our DB in the stack trace, and actually update the DB
            //            context.SaveChanges();


            //            settingsLocally = context.Settings.Local.Count();
            //            //This will now be 1 rather than 0
            //            settingsDatabase = context.Settings.Count();

            //            firstLocal = context.Settings.Local.FirstOrDefault();
            //            firstDatabase = context.Settings.FirstOrDefault();
            //        }
            //    }
            //}
        }
    }
}
