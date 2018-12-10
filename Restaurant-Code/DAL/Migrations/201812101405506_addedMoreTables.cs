namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedMoreTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        roleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        nbStaffMember = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.Ingredients", "defaultquantityInStock");
            DropColumn("dbo.KitchenTools", "defaultQuantityInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KitchenTools", "defaultQuantityInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Ingredients", "defaultquantityInStock", c => c.Int(nullable: false));
            DropTable("dbo.Roles");
            DropTable("dbo.Members");
        }
    }
}
