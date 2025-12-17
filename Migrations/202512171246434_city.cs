namespace MVC_with_EF__CRUD_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class city : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblCities");
        }
    }
}
