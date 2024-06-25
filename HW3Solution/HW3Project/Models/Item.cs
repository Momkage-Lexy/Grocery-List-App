using System.ComponentModel.DataAnnotations;

namespace HW3Project.Models{
    public class Item
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "MISSING 'Name' FIELD")]
        public string? Name{ get; set; }

        [Required(ErrorMessage = "MISSING 'Quantity' FIELD")]
        public int? Quantity { get; set; } 

        [Required(ErrorMessage = "MISSING 'Category' FIELD")]
        public string? Category{ get; set; }

        public override string ToString()
        {
            return $"Item Name: {Name}, Number of Items: {Quantity}, Category: {Category}";
        }
    }
}