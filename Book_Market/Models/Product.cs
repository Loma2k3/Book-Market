using System.ComponentModel.DataAnnotations;

namespace Book_Market.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        public string Quantity { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        public int Price { get; set; }


        public string? Image {  get; set; }

    }
}
