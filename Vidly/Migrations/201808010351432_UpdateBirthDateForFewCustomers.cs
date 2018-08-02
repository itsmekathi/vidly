namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthDateForFewCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers set Birthdate='1992-02-15' where Name='Kathiravan' ");
            Sql("Update Customers set Birthdate='1991-01-28' where Name='Jagan' ");
            Sql("Update Customers set Birthdate='1990-02-16' where Name='Thiruveni' ");
        }
        
        public override void Down()
        {
        }
    }
}
