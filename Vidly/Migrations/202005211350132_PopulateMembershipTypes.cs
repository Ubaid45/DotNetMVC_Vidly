namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 'Ubaid', 0, 0, 0)");
            Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'Ali',30, 1, 10)");
            Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 'Sibgha',90, 3, 15)");
            Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 'Abk',300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
