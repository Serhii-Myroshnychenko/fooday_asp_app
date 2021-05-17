using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : DbContext
    {
       
        public ApplicationDbContext() : base("name=DefaultConnection") {

        }
        public DbSet<product_category> category { get; set;}
    }
}