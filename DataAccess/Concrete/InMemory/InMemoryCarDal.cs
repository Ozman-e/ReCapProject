using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id="1214152", BrandId="1", ColorId="12ZB34W", DailyPrice=150.123, ModelYear=2016, Description="Audi A6 2.0TDI"},
                new Car{Id="1154363", BrandId="2", ColorId="52AB14W", DailyPrice=250.000, ModelYear=2015, Description="Mercedes E Class 200"},
                new Car{Id="1463141", BrandId="3", ColorId="125OP12", DailyPrice=440.500, ModelYear=1975, Description="Chevrolet Camaro SS Classic"}


            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            //linq
            Car carToDelete = _car.SingleOrDefault(p => p.Id == car.Id);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GettAllByModelYear(int ModelYear)
        {
            return _car.Where(p => p.ModelYear == ModelYear).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            

        }
    }
}
