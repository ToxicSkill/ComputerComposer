namespace ComputerComposerNsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Color = c.String(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                        Price = c.Single(nullable: false),
                        RGB = c.Boolean(nullable: false),
                        BoxId = c.Int(nullable: false),
                        GraphicId = c.Int(nullable: false),
                        OSystemId = c.Int(nullable: false),
                        PowerUnitId = c.Int(nullable: false),
                        ProcessorId = c.Int(nullable: false),
                        RamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Boxes", t => t.BoxId, cascadeDelete: true)
                .ForeignKey("dbo.Graphics", t => t.GraphicId, cascadeDelete: true)
                .ForeignKey("dbo.OSystems", t => t.OSystemId, cascadeDelete: true)
                .ForeignKey("dbo.PowerUnits", t => t.PowerUnitId, cascadeDelete: true)
                .ForeignKey("dbo.Processors", t => t.ProcessorId, cascadeDelete: true)
                .ForeignKey("dbo.Rams", t => t.RamId, cascadeDelete: true)
                .Index(t => t.BoxId)
                .Index(t => t.GraphicId)
                .Index(t => t.OSystemId)
                .Index(t => t.PowerUnitId)
                .Index(t => t.ProcessorId)
                .Index(t => t.RamId);
            
            CreateTable(
                "dbo.Graphics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Speed = c.Int(nullable: false),
                        VRam = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OSystems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PowerUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Power = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Processors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Cores = c.Int(nullable: false),
                        Threads = c.Int(nullable: false),
                        Speed = c.Single(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Speed = c.Int(nullable: false),
                        Capacity = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Computers", "RamId", "dbo.Rams");
            DropForeignKey("dbo.Computers", "ProcessorId", "dbo.Processors");
            DropForeignKey("dbo.Computers", "PowerUnitId", "dbo.PowerUnits");
            DropForeignKey("dbo.Computers", "OSystemId", "dbo.OSystems");
            DropForeignKey("dbo.Computers", "GraphicId", "dbo.Graphics");
            DropForeignKey("dbo.Computers", "BoxId", "dbo.Boxes");
            DropIndex("dbo.Computers", new[] { "RamId" });
            DropIndex("dbo.Computers", new[] { "ProcessorId" });
            DropIndex("dbo.Computers", new[] { "PowerUnitId" });
            DropIndex("dbo.Computers", new[] { "OSystemId" });
            DropIndex("dbo.Computers", new[] { "GraphicId" });
            DropIndex("dbo.Computers", new[] { "BoxId" });
            DropTable("dbo.Users");
            DropTable("dbo.Rams");
            DropTable("dbo.Processors");
            DropTable("dbo.PowerUnits");
            DropTable("dbo.OSystems");
            DropTable("dbo.Graphics");
            DropTable("dbo.Computers");
            DropTable("dbo.Boxes");
        }
    }
}
