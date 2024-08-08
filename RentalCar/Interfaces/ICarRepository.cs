
using RentalCar.Models;

namespace RentalCar.Interfaces
{
    public interface ICarRepository
    {
        Task Create(Car car);
        Task<Car> GetById(int id);
        Task<List<Car>> GetAll();
        Task Update(Car car);
        Task Delete(int id);
    }
}
