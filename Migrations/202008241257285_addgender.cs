namespace FitnessApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addgender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Signups", "ConfirmPassword", c => c.String(nullable: false));
            AddColumn("dbo.UserDetails", "Gender", c => c.String());
            DropColumn("dbo.Signups", "ConformPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Signups", "ConformPassword", c => c.String(nullable: false));
            DropColumn("dbo.UserDetails", "Gender");
            DropColumn("dbo.Signups", "ConfirmPassword");
        }
    }
}
