using System;
using RentACar.Core;

namespace RentACar.Entities;

public class Rent : Entity<Guid>
{
    public Guid CustomerId { get; set; }
    public Guid CarId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual Car Car { get; set; }
}