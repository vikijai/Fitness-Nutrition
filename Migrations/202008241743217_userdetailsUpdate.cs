namespace FitnessApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userdetailsUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserDetails", "Bmivalue", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserDetails", "Bmivalue", c => c.Int(nullable: false));
        }
    }
}
