namespace CaffeMeoo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataBaseCF : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        tableId = c.String(nullable: false, maxLength: 128),
                        billId = c.String(),
                        Total = c.Int(nullable: false),
                        PaymentTime = c.String(),
                    })
                .PrimaryKey(t => t.tableId);
            
            CreateTable(
                "dbo.TableDetails",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        SL = c.Int(nullable: false),
                        Name = c.String(),
                        Total = c.Int(nullable: false),
                        Bills_tableId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Bills", t => t.Bills_tableId)
                .Index(t => t.Bills_tableId);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        BookingTime = c.String(),
                        FullName = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DrinkName = c.String(),
                        Quantity = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cats",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Price = c.String(),
                        Available = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Gender = c.String(),
                        DateOfBirth = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Birthday = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Drinks",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Available = c.String(),
                        Price = c.String(),
                        Type = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        DateOfBirth = c.String(),
                        Gender = c.String(),
                        Shift = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Salary = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Available = c.String(),
                        Price = c.String(),
                        Point = c.String(),
                        Type = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MasterUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Username = c.String(),
                        Password = c.String(),
                        Gender = c.String(),
                        Fullname = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Position = c.String(),
                        Birthday = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Fullname = c.String(),
                        Star = c.Int(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TakeUserNames",
                c => new
                    {
                        nameId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.nameId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Username = c.String(),
                        Password = c.String(),
                        Gender = c.String(),
                        Fullname = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Position = c.String(),
                        Birthday = c.String(),
                        Avatar = c.String(),
                        Master = c.String(),
                        hasBooking = c.String(),
                        Point = c.Int(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WorkShifts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmployeePhoneNumber = c.String(),
                        Shift = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TableDetails", "Bills_tableId", "dbo.Bills");
            DropIndex("dbo.TableDetails", new[] { "Bills_tableId" });
            DropTable("dbo.WorkShifts");
            DropTable("dbo.Users");
            DropTable("dbo.TakeUserNames");
            DropTable("dbo.Tables");
            DropTable("dbo.Ratings");
            DropTable("dbo.MasterUsers");
            DropTable("dbo.Items");
            DropTable("dbo.Employees");
            DropTable("dbo.Drinks");
            DropTable("dbo.Customers");
            DropTable("dbo.Cats");
            DropTable("dbo.CartItems");
            DropTable("dbo.Bookings");
            DropTable("dbo.TableDetails");
            DropTable("dbo.Bills");
        }

    }
}
