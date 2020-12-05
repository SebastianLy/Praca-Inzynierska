namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresy",
                c => new
                    {
                        ID_Adresu = c.Int(nullable: false, identity: true),
                        Miejscowosc = c.String(maxLength: 255),
                        Ulica = c.String(maxLength: 255),
                        Nr_Domu = c.String(maxLength: 15, unicode: false),
                        Nr_Mieszkania = c.String(maxLength: 15, unicode: false),
                        Kod_Pocztowy = c.String(maxLength: 5, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.ID_Adresu);
            
            CreateTable(
                "dbo.Uzytkownicy",
                c => new
                    {
                        ID_Uzytkownika = c.Int(nullable: false, identity: true),
                        Login = c.String(maxLength: 255, unicode: false),
                        Email = c.String(maxLength: 255, unicode: false),
                        Imie = c.String(maxLength: 255),
                        Nazwisko = c.String(maxLength: 255),
                        Haslo = c.String(maxLength: 128, fixedLength: true, unicode: false),
                        Rola = c.String(maxLength: 7, unicode: false),
                        Blokada = c.Boolean(nullable: false),
                        Powod_Blokady = c.String(maxLength: 255),
                        ID_Adresu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Uzytkownika)
                .ForeignKey("dbo.Adresy", t => t.ID_Adresu, cascadeDelete: true)
                .Index(t => t.ID_Adresu);
            
            CreateTable(
                "dbo.Platnosci",
                c => new
                    {
                        ID_Platnosci = c.Int(nullable: false, identity: true),
                        Kwota = c.Decimal(nullable: false, storeType: "smallmoney"),
                        Data_Zaplaty = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Opis_Zaplaty = c.String(maxLength: 255),
                        Placacy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Platnosci)
                .ForeignKey("dbo.Uzytkownicy", t => t.Placacy, cascadeDelete: true)
                .Index(t => t.Placacy);
            
            CreateTable(
                "dbo.Sygnatury",
                c => new
                    {
                        ID_Sygnatura = c.String(nullable: false, maxLength: 63, unicode: false),
                        Czas_Rezerwacji = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Aktualny_Posiadacz = c.Int(nullable: false),
                        ID_Ksiazki = c.Int(nullable: false),
                        ID_Wypozyczenia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Sygnatura)
                .ForeignKey("dbo.Ksiazki", t => t.ID_Ksiazki, cascadeDelete: true)
                .ForeignKey("dbo.Uzytkownicy", t => t.Aktualny_Posiadacz, cascadeDelete: true)
                .ForeignKey("dbo.Wypozyczenia", t => t.ID_Wypozyczenia, cascadeDelete: true)
                .Index(t => t.Aktualny_Posiadacz)
                .Index(t => t.ID_Ksiazki)
                .Index(t => t.ID_Wypozyczenia);
            
            CreateTable(
                "dbo.Ksiazki",
                c => new
                    {
                        ID_Ksiazki = c.Int(nullable: false, identity: true),
                        Tytul = c.String(maxLength: 255),
                        Autor = c.String(maxLength: 255),
                        Gatunek = c.String(maxLength: 255, unicode: false),
                        Wydawca = c.String(maxLength: 255),
                        Data_Wydania = c.String(maxLength: 4, fixedLength: true, unicode: false),
                        Miejsce_Wydania = c.String(maxLength: 255),
                        Wartosc = c.Decimal(nullable: false, storeType: "smallmoney"),
                    })
                .PrimaryKey(t => t.ID_Ksiazki);
            
            CreateTable(
                "dbo.Wypozyczenia",
                c => new
                    {
                        ID_Wypozyczenia = c.Int(nullable: false, identity: true),
                        Data_Wypozyczenia = c.DateTime(nullable: false, storeType: "date"),
                        Data_Zwrotu = c.DateTime(nullable: false, storeType: "date"),
                        Czy_Zwrocone = c.Boolean(nullable: false),
                        Czytelnik = c.Int(nullable: false),
                        Uzytkownik_ID_Uzytkownika = c.Int(),
                        Uzytkownik_ID_Uzytkownika1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID_Wypozyczenia)
                .ForeignKey("dbo.Uzytkownicy", t => t.Uzytkownik_ID_Uzytkownika)
                .ForeignKey("dbo.Uzytkownicy", t => t.Uzytkownik_ID_Uzytkownika1)
                .Index(t => t.Uzytkownik_ID_Uzytkownika)
                .Index(t => t.Uzytkownik_ID_Uzytkownika1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wypozyczenia", "Uzytkownik_ID_Uzytkownika1", "dbo.Uzytkownicy");
            DropForeignKey("dbo.Wypozyczenia", "Uzytkownik_ID_Uzytkownika", "dbo.Uzytkownicy");
            DropForeignKey("dbo.Sygnatury", "ID_Wypozyczenia", "dbo.Wypozyczenia");
            DropForeignKey("dbo.Sygnatury", "Aktualny_Posiadacz", "dbo.Uzytkownicy");
            DropForeignKey("dbo.Sygnatury", "ID_Ksiazki", "dbo.Ksiazki");
            DropForeignKey("dbo.Platnosci", "Placacy", "dbo.Uzytkownicy");
            DropForeignKey("dbo.Uzytkownicy", "ID_Adresu", "dbo.Adresy");
            DropIndex("dbo.Wypozyczenia", new[] { "Uzytkownik_ID_Uzytkownika1" });
            DropIndex("dbo.Wypozyczenia", new[] { "Uzytkownik_ID_Uzytkownika" });
            DropIndex("dbo.Sygnatury", new[] { "ID_Wypozyczenia" });
            DropIndex("dbo.Sygnatury", new[] { "ID_Ksiazki" });
            DropIndex("dbo.Sygnatury", new[] { "Aktualny_Posiadacz" });
            DropIndex("dbo.Platnosci", new[] { "Placacy" });
            DropIndex("dbo.Uzytkownicy", new[] { "ID_Adresu" });
            DropTable("dbo.Wypozyczenia");
            DropTable("dbo.Ksiazki");
            DropTable("dbo.Sygnatury");
            DropTable("dbo.Platnosci");
            DropTable("dbo.Uzytkownicy");
            DropTable("dbo.Adresy");
        }
    }
}
