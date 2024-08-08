using RentalCar.Interfaces;
using RentalCar.Models;

namespace RentalCar.Services
{
    internal class CarService(ICarRepository carRepository) : ICarService
    {
        private readonly ICarRepository _carRepository = carRepository;
        public Task Create(Car car)
        {
            return _carRepository.Create(car);
        }

        public Task<Car> GetById(int id)
        {
            return _carRepository.GetById(id);
        }

        public Task<List<Car>> GetAll()
        {
            return _carRepository.GetAll();
        }

        public Task Update(Car car)
        {
            return _carRepository.Update(car);
        }

        public Task Delete(int id)
        {
            return _carRepository.Delete(id);
        }
    }
}
