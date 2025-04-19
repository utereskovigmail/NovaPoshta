using Microsoft.EntityFrameworkCore;
using NovaPoshtaParalle.Entities;

namespace NovaPoshtaParalle
{
    public class MyApplicationContext : DbContext
    {
        /// <summary>
        /// У БД буде табличка tbl_categories
        /// </summary>
        public DbSet<Area> Areas { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<DepartmentEntity> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=/Users/utereskovygmail.com/Downloads/SP_P32-main-2/NovaPoshtaParalle/NovaPoshtaParalle/Base");
        }
    }
}

