namespace MedicalAffairsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEdugrant4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EducationGrants", "LinksAsString", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EducationGrants", "LinksAsString");
        }
    }
}
