using System.Data.Entity.ModelConfiguration;

namespace EntityFramwork_FluentApi_and_DataAnotations.Config
{
    public class CustomerConfig:EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(p => p.Email).IsRequired().HasMaxLength(200);
        }
    }
}
