namespace FitnessApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foodplans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dietplan = c.String(),
                        Workoutplan = c.String(),
                        Healthyreciepy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Bmivalue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserDetails");
            DropTable("dbo.Logins");
            DropTable("dbo.Foodplans");
        }
    }
}
