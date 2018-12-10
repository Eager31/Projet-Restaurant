namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInterTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InstructionInDishes",
                c => new
                    {
                        InstructionID = c.Int(nullable: false),
                        DishID = c.Int(nullable: false),
                        Step = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InstructionID, t.DishID, t.Step });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InstructionInDishes");
        }
    }
}
