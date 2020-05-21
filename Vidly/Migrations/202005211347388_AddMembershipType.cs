namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipType",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Customer", "MembershipTypeId");
            AddForeignKey("dbo.Customer", "MembershipTypeId", "dbo.MembershipType", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customer", "MembershipTypeId", "dbo.MembershipType");
            DropIndex("dbo.Customer", new[] { "MembershipTypeId" });
            DropTable("dbo.MembershipType");
        }
    }
}
