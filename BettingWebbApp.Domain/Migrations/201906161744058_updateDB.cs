namespace BettingWebbApp.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bettings", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Bettings", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Bettings", "Category", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bettings", "Category", c => c.String());
            AlterColumn("dbo.Bettings", "Description", c => c.String());
            AlterColumn("dbo.Bettings", "Name", c => c.String());
        }
    }
}
