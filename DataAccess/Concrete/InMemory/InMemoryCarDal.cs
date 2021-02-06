using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        //Private
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=10000, Description="Makam Aracı - Mercedes", year="2018"},
                new Car{CarId=2, BrandId=1, ColorId=2, DailyPrice=2000, Description="Ticari Arac - Mercedes", year="2010"},
                new Car{CarId=3, BrandId=2, ColorId=2, DailyPrice=13000, Description="Makam Aracı - BMW", year="2020"},
                new Car{CarId=4, BrandId=1, ColorId=1, DailyPrice=7000, Description="Panelvan - Mercedes", year="2021"},
                new Car{CarId=5, BrandId=1, ColorId=2, DailyPrice=10000, Description="B sınıfı araç- Mercedes", year="2019"},
                new Car{CarId=6, BrandId=2, ColorId=2, DailyPrice=4000, Description="E sınıfı- BMW", year="2018"},
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            var updatedCar = _cars.SingleOrDefault(p=>p.CarId == car.CarId);
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
            updatedCar.year = car.year;
        }
        public void Delete(Car car)
        {
            var deletedCar = _cars.SingleOrDefault(p=>p.CarId == car.CarId);
            _cars.Remove(deletedCar);
        }

        public Car Get(int carId)
        {
            return _cars.SingleOrDefault(p=>p.CarId == carId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();

        }
    }
}
