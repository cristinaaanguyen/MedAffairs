namespace MedicalAffairsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateunit21 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EducationGrants", "BusinessUnitId", "dbo.BusinessUnits");
            DropForeignKey("dbo.ResearchGrants", "BusinessUnitId", "dbo.BusinessUnits");
            DropPrimaryKey("dbo.BusinessUnits");
            AlterColumn("dbo.BusinessUnits", "Id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.BusinessUnits", "Id");
            AddForeignKey("dbo.EducationGrants", "BusinessUnitId", "dbo.BusinessUnits", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ResearchGrants", "BusinessUnitId", "dbo.BusinessUnits", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ResearchGrants", "BusinessUnitId", "dbo.BusinessUnits");
            DropForeignKey("dbo.EducationGrants", "BusinessUnitId", "dbo.BusinessUnits");
            DropPrimaryKey("dbo.BusinessUnits");
            AlterColumn("dbo.BusinessUnits", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.BusinessUnits", "Id");
            AddForeignKey("dbo.ResearchGrants", "BusinessUnitId", "dbo.BusinessUnits", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EducationGrants", "BusinessUnitId", "dbo.BusinessUnits", "Id", cascadeDelete: true);
        }
    }
}
