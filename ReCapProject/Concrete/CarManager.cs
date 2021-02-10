using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
            new Car {BrandId=1, Description="2016 audi a6", DailyPrice=100, ModelYear=2016};



        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Aracınız başarıyla eklenmiştir.");
            }
            else
            {
                Console.WriteLine("Günlük fiyat kısmını 0'dan büyük bir değer giriniz");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Aracınız başarıyla silinmiştir.");
        }

        public List<Car> GetAll()
        {
            ////...
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }


        public List<Car> GetAllByModelYear(int year)
        {
            return _carDal.GetAll(c => c.ModelYear == year);
        }

        public Car GetById(int id)
        {
           return _carDal.Get(c => c.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Updated(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Update(car);
                Console.WriteLine("Araba başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine($"Lütfen günlük fiyat kısmını 0'dan büyük giriniz. Girdiğiniz değer : {car.DailyPrice}");
            }
        }

        List<Car> ICarService.GetAll()
        {
            return _carDal.GetAll();


        }
    }
}
