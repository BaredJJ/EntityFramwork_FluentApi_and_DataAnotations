using System.Data.Entity.ModelConfiguration;


namespace EntityFramwork_FluentApi_and_DataAnotations.Config
{
    class ShopConfig:EntityTypeConfiguration<Shop>
    {
        public ShopConfig()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(100);
            Property(p => p.Adress).IsRequired().HasMaxLength(200);
        }
    }
}
