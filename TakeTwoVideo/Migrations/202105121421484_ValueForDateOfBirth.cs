namespace TakeTwoVideo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValueForDateOfBirth : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers Set DateOfBirth = '1977-09-01' WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
