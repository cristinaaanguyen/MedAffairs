namespace MedicalAffairsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingOtherTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                        InfoLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EducationGrants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusinessUnitId = c.Byte(nullable: false),
                        Description = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusinessUnits", t => t.BusinessUnitId, cascadeDelete: true)
                .Index(t => t.BusinessUnitId);
            
            CreateTable(
                "dbo.ResearchGrants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusinessUnitId = c.Byte(nullable: false),
                        Description = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusinessUnits", t => t.BusinessUnitId, cascadeDelete: true)
                .Index(t => t.BusinessUnitId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ResearchGrants", "BusinessUnitId", "dbo.BusinessUnits");
            DropForeignKey("dbo.EducationGrants", "BusinessUnitId", "dbo.BusinessUnits");
            DropIndex("dbo.ResearchGrants", new[] { "BusinessUnitId" });
            DropIndex("dbo.EducationGrants", new[] { "BusinessUnitId" });
            DropTable("dbo.ResearchGrants");
            DropTable("dbo.EducationGrants");
            DropTable("dbo.Categories");
        }
    }
}
