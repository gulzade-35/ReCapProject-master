using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryCarDal : ICarDal
    public class InMemoryCarDal
    {
        //List<Car> _cars;
        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car>
        //    {
        //     new Car{Id=1, BrandId=1, ColorId=1, ModelYear=2020, DailyPrice=1000, Description="Peugeot 208" },
        //     new Car{Id=2, BrandId=1, ColorId=1, ModelYear=2018, DailyPrice=750, Description="Fiat Egea" },
        //     new Car{Id=3, BrandId=1, ColorId=2, ModelYear=2016, DailyPrice=600, Description="Renault Clio" },
        //     new Car{Id=4, BrandId=2, ColorId=1, ModelYear=2015, DailyPrice=550, Description="Hyundai Loniq" },
        //     new Car{Id=5, BrandId=2, ColorId=2, ModelYear=2013, DailyPrice=840, Description="Seat Toledo" }

        //    };
        //}
        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

        //    _cars.Remove(carToDelete);
        //}

        //public Car Get(Expression<Func<Car, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetAll() { }
        //{
        //    return _cars;
        //}

        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetById(int Id) { }
        //{
        //    return _cars.Where(c => c.Id == Id).ToList();
        //}

        //public void Update(Car car) { }
        //{
        //    Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        //    carToDelete.BrandId = car.BrandId;
        //    carToDelete.ColorId = car.ColorId;
        //    carToDelete.ModelYear = car.ModelYear;
        //    carToDelete.DailyPrice = car.DailyPrice;
        //    carToDelete.Description = car.Description;
        //}
    }
}
