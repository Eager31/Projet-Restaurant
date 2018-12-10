namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ingredients", "defaultquantityInStock", c => c.Int(nullable: false));
            AddColumn("dbo.KitchenTools", "defaultQuantityInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.KitchenTools", "defaultQuantityInStock");
            DropColumn("dbo.Ingredients", "defaultquantityInStock");
        }
    }
}
