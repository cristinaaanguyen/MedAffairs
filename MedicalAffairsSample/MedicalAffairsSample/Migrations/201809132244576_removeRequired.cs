namespace MedicalAffairsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EducationGrants", "LinksAsString", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EducationGrants", "LinksAsString", c => c.String(nullable: false));
        }
    }
}
