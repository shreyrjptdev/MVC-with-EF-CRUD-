namespace MVC_with_EF__CRUD_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblGenders",
                c => new
                    {
                        gid = c.Int(nullable: false, identity: true),
                        gname = c.String(),
                    })
                .PrimaryKey(t => t.gid);
            
            AddColumn("dbo.tblStudents", "gender", c => c.Int(nullable: false));
            DropColumn("dbo.tblStudents", "city");
            DropTable("dbo.tblCities");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tblCities",
                c => new
                    {
                        cid = c.Int(nullable: false, identity: true),
                        sid = c.Int(nullable: false),
                        cname = c.String(),
                    })
                .PrimaryKey(t => t.cid);
            
            AddColumn("dbo.tblStudents", "city", c => c.Int(nullable: false));
            DropColumn("dbo.tblStudents", "gender");
            DropTable("dbo.tblGenders");
        }
    }
}
