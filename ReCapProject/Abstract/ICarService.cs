using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Updated(Car car);
        void Delete(Car car);
        List<Car> GetAll();
        Car GetById(string id);
        List<Car> GetAllByBrandId(string id);
        List<Car> GetAllByModelYear(int year);




    }
}
