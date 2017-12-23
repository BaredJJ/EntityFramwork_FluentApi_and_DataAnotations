using System.Data.Entity.ModelConfiguration;

namespace EntityFramwork_FluentApi_and_DataAnotations.Config
{
    public class ProductConfig:EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
            HasKey(p => p.Id);
            //Property(p => p.Name).IsRequired().HasMaxLength(50);
            //Property(p => p.CompanyName).IsRequired().HasMaxLength(200);
            //Property(p => p.PartNumber).IsRequired().HasMaxLength(200);
            Map(p =>
            {
                p.Properties(e => new {e.Id, e.Name});
                p.ToTable("Catalog");
            });

            Map(p =>
            {
                p.Properties(e => new {e.Id, e.CompanyName, e.PartNumber, e.Coast});
                p.ToTable("Product");
            });
        }
    }
}
