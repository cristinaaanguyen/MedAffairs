namespace MedicalAffairsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEduGrant1 : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO BusinessUnits (Name, Description, InfoLink) VALUES ('HVT', 'HVT Description Lorem ipsum dolor sit amet, nonummy ligula volutpat hac integer nonummy. Suspendisse ultricies, congue etiam tellus, erat libero, " +
    "nulla eleifend, mauris pellentesque. Suspendisse integer praesent vel, integer gravida mauris, fringilla vehicula lacinia non Lorem ipsum dolor sit amet, nonummy ligula volutpat hac integer nonummy. Suspendisse ultricies, " +
    "congue etiam tellus, erat libero, nulla eleifend, mauris pellentesque. Suspendisse integer praesent vel, integer gravida mauris, fringilla vehicula lacinia non', 'learnmorelink')");

            Sql("INSERT INTO BusinessUnits (Name, Description, InfoLink) VALUES ('THV', 'THV Description Lorem ipsum dolor sit amet, nonummy ligula volutpat hac integer nonummy. Suspendisse ultricies, congue etiam tellus, erat libero, " +
               "nulla eleifend, mauris pellentesque. Suspendisse integer praesent vel, integer gravida mauris, fringilla vehicula lacinia non Lorem ipsum dolor sit amet, nonummy ligula volutpat hac integer nonummy. Suspendisse ultricies, " +
               "congue etiam tellus, erat libero, nulla eleifend, mauris pellentesque. Suspendisse integer praesent vel, integer gravida mauris, fringilla vehicula lacinia non', 'learnmorelink')");

            Sql("INSERT INTO EducationGrants(Name, Description, LinksAsString, BusinessUnitId, BusinessUnit) VALUES ('Education Grant 1', 'Education Grant 1 description', 'Link1,Link2', 1, 'HVT')");
        }
        
        public override void Down()
        {
        }
    }
}
