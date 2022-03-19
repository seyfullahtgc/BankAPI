using System.ComponentModel.DataAnnotations;

namespace BankAPI.Model
{
    public class CustomerOrder
    {
        [Key]
        public int CustomerOrderId { get; set; }

        [Required(ErrorMessage = "{0} is required."), Display(Name = "Customer")]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "{0} is required."), Display(Name = "Product")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "{0} is required."), Display(Name = "Quantity")]
        public int Quantity { get; set; }
        public Customer Customer { get; set; }

        public  Product Product { get; set; }   



    }
}
