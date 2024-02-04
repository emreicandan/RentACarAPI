using System;
using RentACar.Context;
using RentACar.Core;
using RentACar.Entities;
using RentACar.Repositories.Abstract;

namespace RentACar.Repositories.Concretes;

public class CarRepository : BaseRepository<Car>, ICarRepository
{
    public CarRepository(RentACarDbContext context) : base(context)
    {
    }
}

