using System.ComponentModel.DataAnnotations;

namespace Book_Market.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Username is required.")]
        public string userName {  get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string name {  get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string address {  get; set; }

        [Phone(ErrorMessage = "Invalid phone number.")]
        public string phoneNumber { get; set; }

        public string? image {  get; set; }

        public string role { get; set; }

    }
}
