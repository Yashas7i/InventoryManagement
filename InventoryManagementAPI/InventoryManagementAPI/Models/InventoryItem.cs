using System.ComponentModel.DataAnnotations;

namespace InventoryAPI.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string? Category { get; set; }
    }
}
