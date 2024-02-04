using System;
using RentACar.Core;

namespace RentACar.Entities;

public class User : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string IdentificationNumber { get; set; }
}

