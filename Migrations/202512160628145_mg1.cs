namespace MVC_with_EF__CRUD_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblStudents",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        age = c.Int(nullable: false),
                        state = c.Int(nullable: false),
                        city = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblStudents");
        }
    }
}
