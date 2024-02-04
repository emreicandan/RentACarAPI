using System;
using RentACar.Core;

namespace RentACar.Entities;

public class Car : Entity<Guid>
{
    public string Brand { get; set; }
    public string Type { get; set; }
    public short YearOfProduction { get; set; }
    public string FuelType { get; set; }
    public string Color { get; set; }
    public string Plate { get; set; }
    public decimal DailyFee { get; set; }
    public bool IsActive { get; set; }
}