using System.ComponentModel.DataAnnotations;

namespace BankAPI.Model
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "{0} is required."), Display(Name = "Customer Name"), StringLength(30, MinimumLength = 3, ErrorMessage = "{0} must be min {2} max {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required."), Display(Name = "Customer Address")]
        public int AddressID { get; set; }

        public ICollection<Address> Addresses { get; set; }
        


    }
}
