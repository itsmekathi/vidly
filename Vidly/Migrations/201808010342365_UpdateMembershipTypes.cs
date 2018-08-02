namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes Set MembershipTypeName = 'Pay as you go' where Id = 1");
            Sql("UPDATE MembershipTypes Set MembershipTypeName = 'Monthly' where Id = 2");
            Sql("UPDATE MembershipTypes Set MembershipTypeName = 'Quaterly' where Id = 3");
            Sql("UPDATE MembershipTypes Set MembershipTypeName = 'Annually' where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
