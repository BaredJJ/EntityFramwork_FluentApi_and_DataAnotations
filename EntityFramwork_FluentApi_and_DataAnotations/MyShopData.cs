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
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}