using System.Data.Entity.Migrations;
using Ementor.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Ementor.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Ementor.EntityFramework.EmentorDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Ementor";
        }

        protected override void Seed(Ementor.EntityFramework.EmentorDbContext context)
        {
            context.DisableAllFilters();
            new InitialDataBuilder(context).Build();
        }
    }
}
