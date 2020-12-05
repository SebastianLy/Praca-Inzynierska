namespace Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Model.BibliotekaKontekst>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Model.BibliotekaKontekst";
        }

        protected override void Seed(Model.BibliotekaKontekst context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
