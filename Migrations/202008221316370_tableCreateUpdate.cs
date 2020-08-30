namespace FitnessApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableCreateUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logins", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Logins", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logins", "Password", c => c.String());
            AlterColumn("dbo.Logins", "Username", c => c.String());
        }
    }
}
