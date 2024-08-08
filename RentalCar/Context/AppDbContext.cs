using Microsoft.EntityFrameworkCore;
using RentalCar.Models;

namespace RentalCar.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Carro> Carros { get; set; }
    }
}
