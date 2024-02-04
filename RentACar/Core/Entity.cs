using System;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace RentACar.Core;

public abstract class Entity
{

}

public abstract class Entity<PKey> : Entity
{
    public PKey Id { get; set; }
    
}