using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;


namespace EntityFramwork_FluentApi_and_DataAnotations
{
   // [Table("Customer")]
    public class Customer
    {
       // [Key]
        public int Id { get; set; }
        //[Required, MaxLength(50)]
        public string Name { get; set; }
       // [MaxLength(200)]
        public string Email { get; set; }
        //[Required]
        public ICollection<Product> Product { get; set; }
       // [Required]
        public ICollection<Order> Order { get; set; }

        public Customer()
        {
            Product = new List<Product>();
            Order = new List<Order>();
        }
    }
}
