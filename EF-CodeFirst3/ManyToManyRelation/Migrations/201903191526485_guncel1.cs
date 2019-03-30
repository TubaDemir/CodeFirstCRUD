namespace ManyToManyRelation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class guncel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Egitmen", "Egitmen_EgitmenID", "dbo.Egitmen");
            DropForeignKey("dbo.Ogrencis", "Ogrenci_OgrenciID", "dbo.Ogrencis");
            DropIndex("dbo.Egitmen", new[] { "Egitmen_EgitmenID" });
            DropIndex("dbo.Ogrencis", new[] { "Ogrenci_OgrenciID" });
            CreateTable(
                "dbo.OgrenciEgitmen",
                c => new
                    {
                        Ogrenci_OgrenciID = c.Int(nullable: false),
                        Egitmen_EgitmenID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ogrenci_OgrenciID, t.Egitmen_EgitmenID })
                .ForeignKey("dbo.Ogrencis", t => t.Ogrenci_OgrenciID, cascadeDelete: true)
                .ForeignKey("dbo.Egitmen", t => t.Egitmen_EgitmenID, cascadeDelete: true)
                .Index(t => t.Ogrenci_OgrenciID)
                .Index(t => t.Egitmen_EgitmenID);
            
            DropColumn("dbo.Egitmen", "Egitmen_EgitmenID");
            DropColumn("dbo.Ogrencis", "Ogrenci_OgrenciID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ogrencis", "Ogrenci_OgrenciID", c => c.Int());
            AddColumn("dbo.Egitmen", "Egitmen_EgitmenID", c => c.Int());
            DropForeignKey("dbo.OgrenciEgitmen", "Egitmen_EgitmenID", "dbo.Egitmen");
            DropForeignKey("dbo.OgrenciEgitmen", "Ogrenci_OgrenciID", "dbo.Ogrencis");
            DropIndex("dbo.OgrenciEgitmen", new[] { "Egitmen_EgitmenID" });
            DropIndex("dbo.OgrenciEgitmen", new[] { "Ogrenci_OgrenciID" });
            DropTable("dbo.OgrenciEgitmen");
            CreateIndex("dbo.Ogrencis", "Ogrenci_OgrenciID");
            CreateIndex("dbo.Egitmen", "Egitmen_EgitmenID");
            AddForeignKey("dbo.Ogrencis", "Ogrenci_OgrenciID", "dbo.Ogrencis", "OgrenciID");
            AddForeignKey("dbo.Egitmen", "Egitmen_EgitmenID", "dbo.Egitmen", "EgitmenID");
        }
    }
}
