namespace ManyToManyRelation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Egitmen",
                c => new
                    {
                        EgitmenID = c.Int(nullable: false, identity: true),
                        EgitmenAdi = c.String(),
                        EgitmenSoyadi = c.String(),
                        Egitmen_EgitmenID = c.Int(),
                    })
                .PrimaryKey(t => t.EgitmenID)
                .ForeignKey("dbo.Egitmen", t => t.Egitmen_EgitmenID)
                .Index(t => t.Egitmen_EgitmenID);
            
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        OgrenciID = c.Int(nullable: false, identity: true),
                        OgrenciAdi = c.String(),
                        OgrenciSoyadi = c.String(),
                        Ogrenci_OgrenciID = c.Int(),
                    })
                .PrimaryKey(t => t.OgrenciID)
                .ForeignKey("dbo.Ogrencis", t => t.Ogrenci_OgrenciID)
                .Index(t => t.Ogrenci_OgrenciID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ogrencis", "Ogrenci_OgrenciID", "dbo.Ogrencis");
            DropForeignKey("dbo.Egitmen", "Egitmen_EgitmenID", "dbo.Egitmen");
            DropIndex("dbo.Ogrencis", new[] { "Ogrenci_OgrenciID" });
            DropIndex("dbo.Egitmen", new[] { "Egitmen_EgitmenID" });
            DropTable("dbo.Ogrencis");
            DropTable("dbo.Egitmen");
        }
    }
}
