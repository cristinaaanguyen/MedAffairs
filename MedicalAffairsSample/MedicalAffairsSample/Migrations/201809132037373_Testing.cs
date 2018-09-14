namespace MedicalAffairsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO EducationGrants(Description, BusinessUnitId) VALUES ('Education Grant 1 description', 3)");

        }

        public override void Down()
        {
        }
    }
}
