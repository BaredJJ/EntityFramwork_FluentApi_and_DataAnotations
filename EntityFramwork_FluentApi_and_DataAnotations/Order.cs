using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramwork_FluentApi_and_DataAnotations
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public ICollection<Product> Product { get; set; }

        public Order()
        {
            Customer = new Customer();
            Product = new List<Product>();
        }
    }
}
