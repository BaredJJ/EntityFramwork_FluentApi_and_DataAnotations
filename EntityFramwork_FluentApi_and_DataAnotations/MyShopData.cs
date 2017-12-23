using EntityFramwork_FluentApi_and_DataAnotations.Config;

namespace EntityFramwork_FluentApi_and_DataAnotations
{
    using System.Data.Entity;

    public class MyShopData : DbContext
    {
        static MyShopData()
        {
            Database.SetInitializer(new DbInicilaizer());
        }

        public MyShopData( )
            : base("name=MyShopData")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CustomerConfig());
            modelBuilder.Configurations.Add(new OrderConfig());
            modelBuilder.Configurations.Add(new ProductConfig());
        }
    }   
}