namespace Nursery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(nullable: false),
                        EmployeeAddress = c.String(nullable: false),
                        EmployeePhone = c.Int(nullable: false),
                        EmployeeWorkingHour = c.String(nullable: false),
                        EmployeeSalary = c.String(nullable: false),
                        EmployeeJoiningDate = c.String(nullable: false),
                        EmployeeResigningDate = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.suppliers",
                c => new
                    {
                        SupplierID = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(nullable: false),
                        SupplierAddress = c.String(nullable: false),
                        SupplierPhone = c.Int(nullable: false),
                        SupplierEmail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierID);
            
            CreateTable(
                "dbo.userForRegs",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Phone = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.userForRegs");
            DropTable("dbo.suppliers");
            DropTable("dbo.employees");
        }
    }
}
