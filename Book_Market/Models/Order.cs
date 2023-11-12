using System.ComponentModel.DataAnnotations;

namespace Book_Market.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public string UserName {  get; set; }
        public Guid ProductId { get; set; }

    }
}
