namespace Nursery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration_name2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.plants",
                c => new
                    {
                        plantID = c.Int(nullable: false, identity: true),
                        plantName = c.String(nullable: false),
                        ScientificName = c.String(nullable: false),
                        plantAge = c.String(nullable: false),
                        plantPrice = c.String(nullable: false),
                        plantPicture = c.String(),
                    })
                .PrimaryKey(t => t.plantID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.plants");
        }
    }
}
