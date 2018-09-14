namespace MedicalAffairsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEducationGrant : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO EducationGrants(Name, Description, LinksAsString, BusinessUnitId) VALUES ('Education Grant 1', 'Education Grant 1 description', 'Link1,Link2', 3)");
        }
        
        public override void Down()
        {
        }
    }
}
