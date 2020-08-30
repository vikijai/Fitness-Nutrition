namespace FitnessApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class signupUpdates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Signups", "ErrorMessage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Signups", "ErrorMessage");
        }
    }
}
