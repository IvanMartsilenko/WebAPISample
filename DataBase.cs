using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { gSet; set; }
        public int Count { get; set; }
        
    }
    public class DataBaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
