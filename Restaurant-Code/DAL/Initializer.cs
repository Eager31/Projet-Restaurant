using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataContext>
    {
        public void Seed(DataContext context)
        {
            var slice = new Action { ID = 0, name = "Slice", description = "", duration = 2 };
            var peel = new Action { ID = 1, name = "Peel", description = "", duration = 2 };
            var cook = new Action { ID = 2, name = "Cook", description = "", duration = 2 };
            var fry = new Action { ID = 3, name = "Fry", description = "", duration = 2 };
            var stirFry = new Action { ID = 4, name = "Stir Fry", description = "", duration = 2 };

            var actions = new List<Action>
            {
                slice, peel, cook, fry, stirFry
            };

            actions.ForEach(s => context.Action.Add(s));
            context.SaveChanges();



            var kitchenKnife = new KitchenTool { ID = 0, name = "Kitchen Knife", description = "", quantityInStock = 5 };
            var peeler = new KitchenTool { ID = 1, name = "Peeler", description = "", quantityInStock = 5 };
            var deepFryer = new KitchenTool { ID = 2, name = "Deep Fryer", description = "", quantityInStock = 1 };
            var oven = new KitchenTool { ID = 3, name = "Oven", description = "", quantityInStock = 1 };
            var wok = new KitchenTool { ID = 4, name = "Wok", description = "", quantityInStock = 1 };

            var kitchenTools = new List<KitchenTool>
            {
                kitchenKnife, peeler, deepFryer, oven, wok
            };

            kitchenTools.ForEach(s => context.KitchenTool.Add(s));
            context.SaveChanges();



            var frozen = new IngredientType { ID = 0, name = "Frozen", description = "" };
            var fresh = new IngredientType { ID = 1, name = "Fresh", description = "" };
            var longLife = new IngredientType { ID = 2, name = "Long-Life", description = "" };

            var ingredientTypes = new List<IngredientType>
            {
                frozen, fresh, longLife
            };

            ingredientTypes.ForEach(s => context.IngredientType.Add(s));
            context.SaveChanges();
            


            var potato = new Ingredient { ID = 0, name = "Potato", typeId = fresh.ID, quantityInStock = 250, dateArrival = new DateTime(), dateExpire = new DateTime() };
            var rice = new Ingredient { ID = 1, name = "Rice", typeId = longLife.ID, quantityInStock = 250, dateArrival = new DateTime(), dateExpire = new DateTime() };
            var chicken = new Ingredient { ID = 2, name = "Chicken", typeId = frozen.ID, quantityInStock = 100, dateArrival = new DateTime(), dateExpire = new DateTime() };

            Console.WriteLine(potato.dateArrival);

            var ingredients = new List<Ingredient>
            {
                potato, rice, chicken
            };

            ingredients.ForEach(s => context.Ingredient.Add(s));
            context.SaveChanges();



            var sliceChicken = new Instruction { ID = 0, name = "Slice the chicken", description = "", ingredientId = chicken.ID, actionId = slice.ID, toolId = kitchenKnife.ID };

            var instructions = new List<Instruction>
            {
                sliceChicken
            };

            instructions.ForEach(s => context.Instruction.Add(s));
            context.SaveChanges();


            var dishes = new List<Dish>
            {
                new Dish { ID = 0, name = "Chicken Satay", description = "" }
            };

            dishes.ForEach(s => context.Dish.Add(s));
            context.SaveChanges();
        }
    }
}
