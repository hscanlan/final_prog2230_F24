// Models/Car.cs
using System.ComponentModel.DataAnnotations;

public class Car
{
    [Key]
    public int CarId { get; set; }

    [Required]
    public string? Make { get; set; } // Manufacturer, e.g., Toyota, Ford

    [Required]
    public string? Model { get; set; } // Model name, e.g., Camry, Mustang

    public int? Year { get; set; } // Year of manufacture

    [DataType(DataType.Currency)]
    public decimal? Price { get; set; } // Price of the car
}
