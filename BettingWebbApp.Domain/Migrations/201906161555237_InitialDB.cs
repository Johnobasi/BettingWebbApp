namespace BettingWebbApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bettings",
                c => new
                    {
                        BettingId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Odd = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.BettingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bettings");
        }
    }
}
