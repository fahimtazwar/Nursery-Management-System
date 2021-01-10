namespace Nursery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration_name : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.employees", "EmployeeResigningDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.employees", "EmployeeResigningDate", c => c.String(nullable: false));
        }
    }
}
