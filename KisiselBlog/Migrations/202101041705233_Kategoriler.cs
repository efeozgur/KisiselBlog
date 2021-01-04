namespace KisiselBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Kategoriler : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Yazi", "Kategoriler_ID", c => c.Int());
            CreateIndex("dbo.Yazi", "Kategoriler_ID");
            AddForeignKey("dbo.Yazi", "Kategoriler_ID", "dbo.Kategoriler", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yazi", "Kategoriler_ID", "dbo.Kategoriler");
            DropIndex("dbo.Yazi", new[] { "Kategoriler_ID" });
            DropColumn("dbo.Yazi", "Kategoriler_ID");
            DropTable("dbo.Kategoriler");
        }
    }
}
