namespace MedicalAffairsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBusinessUnits : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.BusinessUnits");
            AddColumn("dbo.BusinessUnits", "Description", c => c.String());
            AddColumn("dbo.BusinessUnits", "InfoLink", c => c.String());
            AlterColumn("dbo.BusinessUnits", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.BusinessUnits", "Id");
            DropColumn("dbo.BusinessUnits", "MedPortalId");
            DropColumn("dbo.BusinessUnits", "TrainingPortalId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BusinessUnits", "TrainingPortalId", c => c.Byte(nullable: false));
            AddColumn("dbo.BusinessUnits", "MedPortalId", c => c.Byte(nullable: false));
            DropPrimaryKey("dbo.BusinessUnits");
            AlterColumn("dbo.BusinessUnits", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.BusinessUnits", "InfoLink");
            DropColumn("dbo.BusinessUnits", "Description");
            AddPrimaryKey("dbo.BusinessUnits", "Id");
        }
    }
}
