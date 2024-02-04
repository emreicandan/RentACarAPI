using System;
using RentACar.Core;

namespace RentACar.Entities;


public class Customer : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string IdentificationNumber { get; set; }
    public string Mail { get; set; }
    public string Phone { get; set; }
    public DateTime BirthDate { get; set; }
}