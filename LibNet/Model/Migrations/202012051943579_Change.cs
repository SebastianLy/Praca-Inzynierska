namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sygnatury", "Czas_Rezerwacji", c => c.DateTime(storeType: "smalldatetime"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sygnatury", "Czas_Rezerwacji", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
        }
    }
}
