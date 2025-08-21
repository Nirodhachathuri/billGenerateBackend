using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public decimal PricePerItem { get; set; }  // price for a single item

    [Required]
    public int Quantity { get; set; }          // stock quantity

    [Required]
    public string Description { get; set; }
}
