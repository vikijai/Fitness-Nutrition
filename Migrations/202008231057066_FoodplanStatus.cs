namespace FitnessApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FoodplanStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foodplans", "status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foodplans", "status");
        }
    }
}
