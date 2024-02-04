using System;
using RentACar.Context;
using RentACar.Core;
using RentACar.Entities;
using RentACar.Repositories.Abstract;

namespace RentACar.Repositories.Concretes;

public class RentRepository : BaseRepository<Rent>, IRentRepository
{
    public RentRepository(RentACarDbContext context) : base(context)
    {
    }
}

