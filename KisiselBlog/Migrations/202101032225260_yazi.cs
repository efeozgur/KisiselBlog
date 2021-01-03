namespace KisiselBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yazi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Yazi",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        baslik = c.String(nullable: false, maxLength: 200),
                        metin = c.String(nullable: false),
                        tarih = c.String(maxLength: 13),
                        yazar = c.String(maxLength: 50),
                        aktif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Yazi");
        }
    }
}
