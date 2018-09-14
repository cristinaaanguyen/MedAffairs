namespace MedicalAffairsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEduGrant : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EducationGrants", "Name", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.EducationGrants", "LinksAsString", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EducationGrants", "LinksAsString");
            DropColumn("dbo.EducationGrants", "Name");
        }
    }
}
