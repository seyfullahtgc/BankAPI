using System.ComponentModel.DataAnnotations;

namespace BankAPI.Model
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "{0} is required."), Display(Name = "Product Name"), StringLength(40, MinimumLength = 2, ErrorMessage = "{0} must be min {2} max {1}")]
        public string ProductName{ get; set; }

        [Required(ErrorMessage = "{0} is required."), Display(Name = "Barcode"), StringLength(13, MinimumLength = 9, ErrorMessage = "{0} must be min {2} max {1}")]
        public string Barcode { get; set; }

        [Required(ErrorMessage = "{0} is required."), Display(Name = "Description"), StringLength(85, MinimumLength = 2, ErrorMessage = "{0} must be min {2} max {1}")]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} is required."), Display(Name = "Price")]
        public int Price { get; set; }
    }
}
