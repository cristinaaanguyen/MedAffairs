namespace MedicalAffairsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBusiniessUnitsandEduGrant : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO BusinessUnits (Name, Description, InfoLink) VALUES ('HVT', 'HVT Description Lorem ipsum dolor sit amet, nonummy ligula volutpat hac integer nonummy. Suspendisse ultricies, congue etiam tellus, erat libero, nulla eleifend, mauris pellentesque. Suspendisse integer praesent vel, integer gravida mauris, fringilla vehicula lacinia non Lorem ipsum dolor sit amet, nonummy ligula volutpat hac integer nonummy. Suspendisse ultricies,congue etiam tellus, erat libero, nulla eleifend, mauris pellentesque. Suspendisse integer praesent vel, integer gravida mauris, fringilla vehicula lacinia non', 'learnmorelink')");


    }
        
        public override void Down()
        {
        }
    }
}
