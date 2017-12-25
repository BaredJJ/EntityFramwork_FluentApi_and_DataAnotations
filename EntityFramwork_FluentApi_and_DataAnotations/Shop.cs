using System.Collections.Generic;

namespace EntityFramwork_FluentApi_and_DataAnotations
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Shop()
        {
            Products = new List<Product>();
            Orders = new List<Order>();
        }
    }
}
