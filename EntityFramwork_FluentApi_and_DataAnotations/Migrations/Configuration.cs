namespace EntityFramwork_FluentApi_and_DataAnotations.Migrations
{

    using System.Data.Entity.Migrations;


    internal sealed class Configuration : DbMigrationsConfiguration<EntityFramwork_FluentApi_and_DataAnotations.MyShopData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EntityFramwork_FluentApi_and_DataAnotations.MyShopData";
        }

        protected override void Seed(EntityFramwork_FluentApi_and_DataAnotations.MyShopData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
