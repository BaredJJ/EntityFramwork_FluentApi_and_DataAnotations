using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramwork_FluentApi_and_DataAnotations
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(200)]
        public string CompanyName { get; set; }
        [Required, MaxLength(200)]
        public string PartNumber { get; set; }
        [Required]
        public double Coast { get; set; }
        [Required]
        public ICollection<Customer> Customer { get; set; }
        [Required]
        public ICollection<Order> Order { get; set; }

        public Product()
        {
            Customer = new List<Customer>();
            Order = new List<Order>();
        }
    }
}
