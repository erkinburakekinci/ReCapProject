using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal

    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1 ,BrandId=1, ColorId=1, ModelYear=1994, DailyPrice=35000, Description="Corsa Gsi"},
                new Car {Id=1 ,BrandId=1, ColorId=2, ModelYear=1994, DailyPrice=60000, Description="Opel Gsi"},
                new Car {Id=1 ,BrandId=2, ColorId=3, ModelYear=2006, DailyPrice=430000, Description="EVO 9"},
                new Car {Id=1 ,BrandId=2, ColorId=2, ModelYear=2005, DailyPrice=375000, Description="EVO 8"},
                new Car {Id=1 ,BrandId=3, ColorId=4, ModelYear=2005, DailyPrice=400000, Description="Impreza 2.0 WRX STI "}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
