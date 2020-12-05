namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sygnatury", "Aktualny_Posiadacz", "dbo.Uzytkownicy");
            DropIndex("dbo.Sygnatury", new[] { "Aktualny_Posiadacz" });
            AlterColumn("dbo.Sygnatury", "Aktualny_Posiadacz", c => c.Int());
            CreateIndex("dbo.Sygnatury", "Aktualny_Posiadacz");
            AddForeignKey("dbo.Sygnatury", "Aktualny_Posiadacz", "dbo.Uzytkownicy", "ID_Uzytkownika");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sygnatury", "Aktualny_Posiadacz", "dbo.Uzytkownicy");
            DropIndex("dbo.Sygnatury", new[] { "Aktualny_Posiadacz" });
            AlterColumn("dbo.Sygnatury", "Aktualny_Posiadacz", c => c.Int(nullable: false));
            CreateIndex("dbo.Sygnatury", "Aktualny_Posiadacz");
            AddForeignKey("dbo.Sygnatury", "Aktualny_Posiadacz", "dbo.Uzytkownicy", "ID_Uzytkownika", cascadeDelete: true);
        }
    }
}
