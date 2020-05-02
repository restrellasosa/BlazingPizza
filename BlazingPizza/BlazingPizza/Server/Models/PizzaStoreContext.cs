using BlazingPizza.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Server.Models
{
    public class PizzaStoreContext: DbContext
    {
        public DbSet<PizzaSpecial> Specials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=RYAN;Database=PizzaStore;persist security info=True;user=sa;password=ryan1973;MultipleActiveResultSets=true");

        }
    }
}
