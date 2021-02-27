using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id = 1,BrandId = 1, ColorId = 1,ModelYear = 2020, DailyPrice = 700, Description = "Mercedes GLA Serisi 200 1.3 AMG"},
                new Car{Id = 2,BrandId = 1, ColorId = 1,ModelYear = 2020, DailyPrice = 600, Description = "Mercedes A Serisi A180 1.4 Style"},
                new Car{Id = 3,BrandId = 2, ColorId = 1,ModelYear = 2012, DailyPrice = 500, Description = "Honda Jazz 1.4 Joy"},
                new Car{Id = 4,BrandId = 2, ColorId = 1,ModelYear = 2021, DailyPrice = 400, Description = "Honda Civic 1.5 Executive Plus CVT"},
                new Car{Id = 5,BrandId = 3, ColorId = 1,ModelYear = 2021, DailyPrice = 300, Description = "Peugeot 2008 1.2 GT-Line AT"},
                new Car{Id = 6,BrandId = 4, ColorId = 1,ModelYear = 2020, DailyPrice = 200, Description = "Jeep Renegade 1.6 Multijet Limited AT"},



            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
           return _cars.Where(c => c.Id == id).ToList(); //Şarta uyan elemanları yeni bir liste haline getirir.
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
