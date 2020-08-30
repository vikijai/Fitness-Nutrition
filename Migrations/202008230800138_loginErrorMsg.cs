namespace FitnessApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class loginErrorMsg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Logins", "ErrorMessage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Logins", "ErrorMessage");
        }
    }
}
