using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaShop.Models;

namespace PizzaShop.Data
{
    public class PizzaShopContext : DbContext
    {
        public PizzaShopContext (DbContextOptions<PizzaShopContext> options)
            : base(options)
        {
        }

        public DbSet<PizzaShop.Models.Product> Product { get; set; } = default!;
    }
}
