using System.ComponentModel.DataAnnotations;

namespace BankAPI.Model
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        
        [Required(ErrorMessage = "{0} Gerekli."), Display(Name = "Customer")]
        public int CustomerID { get; set; }
        
        [Required(ErrorMessage = "{0} is required."), Display(Name = "Address Name"), StringLength(20, MinimumLength = 3, ErrorMessage = "{0} must be min {2} max {1}")]
        public string AddressName { get; set; }

        [Required(ErrorMessage = "{0} is required."), Display(Name = "Address Detail"), StringLength(200, MinimumLength = 3, ErrorMessage = "{0} must be min {2} max {1}")]
        public string AddressDetail { get; set; }


    }
}
