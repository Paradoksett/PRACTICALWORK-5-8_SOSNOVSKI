using System;
using System.Collections.Generic;

namespace PRACTICALWORK5_8_SOSNOVSKI.Models;

public partial class Car
{
    public int Id { get; set; }

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public decimal Price { get; set; }

    public int? Mileage { get; set; }

    public string? Color { get; set; }

    public string? Vin { get; set; }

    public int BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
