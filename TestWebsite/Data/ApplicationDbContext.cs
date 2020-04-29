using Microsoft.EntityFrameworkCore;

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

        public ApplicationDbContext() {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            //Creates a new database called entityframework using our trusted connection
            optionsBuilder.UseSqlServer("Server=.;Database=entityframework;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}
