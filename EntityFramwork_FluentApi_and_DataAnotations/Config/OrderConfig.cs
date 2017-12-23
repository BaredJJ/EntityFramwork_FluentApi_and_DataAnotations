using System.Data.Entity.ModelConfiguration;


namespace EntityFramwork_FluentApi_and_DataAnotations.Config
{
    public class OrderConfig:EntityTypeConfiguration<Order>
    {
        public OrderConfig()
        {
            HasKey(p => p.Id);          
        }
    }
}
