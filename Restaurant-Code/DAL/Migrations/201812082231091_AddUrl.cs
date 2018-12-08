namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Instructions", "action_ID", "dbo.Actions");
            DropForeignKey("dbo.Ingredients", "type_ID", "dbo.IngredientTypes");
            DropForeignKey("dbo.Instructions", "ingredient_ID", "dbo.Ingredients");
            DropForeignKey("dbo.Instructions", "tool_ID", "dbo.KitchenTools");
            DropForeignKey("dbo.Instructions", "Dish_ID", "dbo.Dishes");
            DropIndex("dbo.Instructions", new[] { "action_ID" });
            DropIndex("dbo.Instructions", new[] { "ingredient_ID" });
            DropIndex("dbo.Instructions", new[] { "tool_ID" });
            DropIndex("dbo.Instructions", new[] { "Dish_ID" });
            DropIndex("dbo.Ingredients", new[] { "type_ID" });
            AddColumn("dbo.Instructions", "ingredientId", c => c.Int(nullable: false));
            AddColumn("dbo.Instructions", "actionId", c => c.Int(nullable: false));
            AddColumn("dbo.Instructions", "toolId", c => c.Int(nullable: false));
            AddColumn("dbo.Ingredients", "typeId", c => c.Int(nullable: false));
            DropColumn("dbo.Instructions", "action_ID");
            DropColumn("dbo.Instructions", "ingredient_ID");
            DropColumn("dbo.Instructions", "tool_ID");
            DropColumn("dbo.Instructions", "Dish_ID");
            DropColumn("dbo.Ingredients", "type_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ingredients", "type_ID", c => c.Int());
            AddColumn("dbo.Instructions", "Dish_ID", c => c.Int());
            AddColumn("dbo.Instructions", "tool_ID", c => c.Int());
            AddColumn("dbo.Instructions", "ingredient_ID", c => c.Int());
            AddColumn("dbo.Instructions", "action_ID", c => c.Int());
            DropColumn("dbo.Ingredients", "typeId");
            DropColumn("dbo.Instructions", "toolId");
            DropColumn("dbo.Instructions", "actionId");
            DropColumn("dbo.Instructions", "ingredientId");
            CreateIndex("dbo.Ingredients", "type_ID");
            CreateIndex("dbo.Instructions", "Dish_ID");
            CreateIndex("dbo.Instructions", "tool_ID");
            CreateIndex("dbo.Instructions", "ingredient_ID");
            CreateIndex("dbo.Instructions", "action_ID");
            AddForeignKey("dbo.Instructions", "Dish_ID", "dbo.Dishes", "ID");
            AddForeignKey("dbo.Instructions", "tool_ID", "dbo.KitchenTools", "ID");
            AddForeignKey("dbo.Instructions", "ingredient_ID", "dbo.Ingredients", "ID");
            AddForeignKey("dbo.Ingredients", "type_ID", "dbo.IngredientTypes", "ID");
            AddForeignKey("dbo.Instructions", "action_ID", "dbo.Actions", "ID");
        }
    }
}
