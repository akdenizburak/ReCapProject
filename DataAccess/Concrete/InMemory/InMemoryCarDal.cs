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
                new Car(){Id=1,BrandId=3,ColorId=4,ModelYear=2020,DailyPrice=490000,Description="SUV"},
                new Car(){Id=2,BrandId=1,ColorId=2,ModelYear=2021,DailyPrice=330000,Description="SEDAN"},
                new Car(){Id=3,BrandId=4,ColorId=2,ModelYear=2018,DailyPrice=250000,Description="HB"},
                new Car(){Id=4,BrandId=2,ColorId=3,ModelYear=2019,DailyPrice=310000,Description="HB"},
                new Car(){Id=5,BrandId=5,ColorId=3,ModelYear=2020,DailyPrice=120000,Description="SUV"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
