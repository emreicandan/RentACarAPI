using System;
using Microsoft.EntityFrameworkCore;
using RentACar.Entities;

namespace RentACar.Context;

public class RentACarDbContext : DbContext
{
    protected IConfiguration _configuration;

    public RentACarDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configurationString = _configuration.GetValue<string>("ConnectionStrings:Developer");
        optionsBuilder.UseSqlServer(configurationString);
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Rent> Rents { get; set; }


}

