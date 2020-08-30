namespace FitnessApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foodplanupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foodplans", "Healthyrecipes", c => c.String());
            DropColumn("dbo.Foodplans", "Healthyreciepy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foodplans", "Healthyreciepy", c => c.String());
            DropColumn("dbo.Foodplans", "Healthyrecipes");
        }
    }
}
