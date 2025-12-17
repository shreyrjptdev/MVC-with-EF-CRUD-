namespace MVC_with_EF__CRUD_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblStudents", "city", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblStudents", "city");
        }
    }
}
