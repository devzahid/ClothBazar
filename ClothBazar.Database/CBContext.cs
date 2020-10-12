using ClothBazar.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Database
{
  public  class CBContext :DbContext
    {
        public CBContext() : base("ClothBAzarConnection") {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category>Categories { get; set; }
    }
}
