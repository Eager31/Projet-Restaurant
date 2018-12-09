namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        duration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Instructions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        action_ID = c.Int(),
                        ingredient_ID = c.Int(),
                        tool_ID = c.Int(),
                        Dish_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Actions", t => t.action_ID)
                .ForeignKey("dbo.Ingredients", t => t.ingredient_ID)
                .ForeignKey("dbo.KitchenTools", t => t.tool_ID)
                .ForeignKey("dbo.Dishes", t => t.Dish_ID)
                .Index(t => t.action_ID)
                .Index(t => t.ingredient_ID)
                .Index(t => t.tool_ID)
                .Index(t => t.Dish_ID);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        quantityInStock = c.Int(nullable: false),
                        dateArrival = c.DateTime(nullable: false),
                        dateExpire = c.DateTime(nullable: false),
                        type_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IngredientTypes", t => t.type_ID)
                .Index(t => t.type_ID);
            
            CreateTable(
                "dbo.IngredientTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KitchenTools",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        quantityInStock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instructions", "Dish_ID", "dbo.Dishes");
            DropForeignKey("dbo.Instructions", "tool_ID", "dbo.KitchenTools");
            DropForeignKey("dbo.Instructions", "ingredient_ID", "dbo.Ingredients");
            DropForeignKey("dbo.Ingredients", "type_ID", "dbo.IngredientTypes");
            DropForeignKey("dbo.Instructions", "action_ID", "dbo.Actions");
            DropIndex("dbo.Ingredients", new[] { "type_ID" });
            DropIndex("dbo.Instructions", new[] { "Dish_ID" });
            DropIndex("dbo.Instructions", new[] { "tool_ID" });
            DropIndex("dbo.Instructions", new[] { "ingredient_ID" });
            DropIndex("dbo.Instructions", new[] { "action_ID" });
            DropTable("dbo.KitchenTools");
            DropTable("dbo.IngredientTypes");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Instructions");
            DropTable("dbo.Dishes");
            DropTable("dbo.Actions");
        }
    }
}
