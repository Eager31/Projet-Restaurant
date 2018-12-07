using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL
{
    class Context : DbContext
    {
        public DbSet<Action> Action { get; set; }
        public DbSet<Dish> Dish { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<IngredientType> IngredientType { get; set; }
        public DbSet<Instruction> Instruction { get; set; }
        public DbSet<KitchenTool> KitchenTool { get; set; }


        public Context() : base("Context")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
