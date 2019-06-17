namespace BettingWebbApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedtime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bettings", "Kickoff", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bettings", "Kickoff");
        }
    }
}
