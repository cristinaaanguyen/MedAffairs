namespace MedicalAffairsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEdugrant3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EducationGrants", "LinksAsString");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EducationGrants", "LinksAsString", c => c.String(nullable: false));
        }
    }
}
