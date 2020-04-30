using Microsoft.EntityFrameworkCore;
using System;

namespace TestWebsite.Data {
    /// <summary>
    /// The database representational model for our application
    /// </summary>
    public class ApplicationDbContext : DbContext {

        #region Public Props

        /// <summary>
        /// Think of this as a table, and SettingsDataModel is a row entry within that table
        /// </summary>
        public DbSet<SettingsDataModel> Settings { get; set; }

        #endregion

        /// <summary>
        /// Constructor now expects options to be passed in
        /// </summary>
        /// <param name="options">Database context options</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            //Fluent API 
            //Another way to configure our column properties in our table, we're now saying Name is indexed
            modelBuilder.Entity<SettingsDataModel>().HasIndex(a => a.Name);
        }
    }
}
