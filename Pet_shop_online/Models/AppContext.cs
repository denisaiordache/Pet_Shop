using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pet_shop_online.Models
{
    public class AppContext:DbContext
    {
        public AppContext() : base("DBConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppContext,
            Pet_shop_online.Migrations.Configuration>("DBConnectionString"));
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment>Comments { get; set; }
        public DbSet<Animal>Animals { get; set; }
    }
}