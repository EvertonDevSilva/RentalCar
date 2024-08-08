using Microsoft.EntityFrameworkCore;
using RentalCar.Context;
using RentalCar.Interfaces;
using RentalCar.Models;

namespace RentalCar.Repositories
{
    internal class CarRepository(AppDbContext context) : ICarRepository
    {
        private readonly AppDbContext context = context;

        public Task Create(Car car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task<Car> GetById(int id)
        {
            return await context.Cars.SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Car>> GetAll()
        {
            return await context.Cars.ToListAsync();
        }

        public Task Update(Car car)
        {
            context.Cars.Update(car);
            return Task.CompletedTask;
        }

        public Task Delete(int id)
        {
            var car = GetById(id).Result;
            context.Cars.Remove(car);
            return Task.CompletedTask;
        }
    }
}
