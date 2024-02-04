using System;
using RentACar.Context;
using RentACar.Core;
using RentACar.Entities;
using RentACar.Repositories.Abstract;

namespace RentACar.Repositories.Concretes;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(RentACarDbContext context) : base(context)
    {
    }
}

