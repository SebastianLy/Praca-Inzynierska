namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRelations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sygnatury", "ID_Wypozyczenia", "dbo.Wypozyczenia");
            DropIndex("dbo.Sygnatury", new[] { "ID_Wypozyczenia" });
            CreateTable(
                "dbo.WypozyczenieSygnaturas",
                c => new
                    {
                        Wypozyczenie_ID_Wypozyczenia = c.Int(nullable: false),
                        Sygnatura_ID_Sygnatura = c.String(nullable: false, maxLength: 63, unicode: false),
                    })
                .PrimaryKey(t => new { t.Wypozyczenie_ID_Wypozyczenia, t.Sygnatura_ID_Sygnatura })
                .ForeignKey("dbo.Wypozyczenia", t => t.Wypozyczenie_ID_Wypozyczenia, cascadeDelete: true)
                .ForeignKey("dbo.Sygnatury", t => t.Sygnatura_ID_Sygnatura, cascadeDelete: true)
                .Index(t => t.Wypozyczenie_ID_Wypozyczenia)
                .Index(t => t.Sygnatura_ID_Sygnatura);
            
            DropColumn("dbo.Sygnatury", "ID_Wypozyczenia");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sygnatury", "ID_Wypozyczenia", c => c.Int(nullable: false));
            DropForeignKey("dbo.WypozyczenieSygnaturas", "Sygnatura_ID_Sygnatura", "dbo.Sygnatury");
            DropForeignKey("dbo.WypozyczenieSygnaturas", "Wypozyczenie_ID_Wypozyczenia", "dbo.Wypozyczenia");
            DropIndex("dbo.WypozyczenieSygnaturas", new[] { "Sygnatura_ID_Sygnatura" });
            DropIndex("dbo.WypozyczenieSygnaturas", new[] { "Wypozyczenie_ID_Wypozyczenia" });
            DropTable("dbo.WypozyczenieSygnaturas");
            CreateIndex("dbo.Sygnatury", "ID_Wypozyczenia");
            AddForeignKey("dbo.Sygnatury", "ID_Wypozyczenia", "dbo.Wypozyczenia", "ID_Wypozyczenia", cascadeDelete: true);
        }
    }
}
