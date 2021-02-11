using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                //Console.WriteLine("Aracınız başarıyla eklenmiştir.");
                return new SuccessResult(Messages.CarAdded);
            }
            return new ErrorResult(Messages.CarNameInvalid);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            //Console.WriteLine("Aracınız başarıyla silinmiştir.");
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            ////...
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c =>c.BrandId == id), Messages.CarsListedByBrandId);
            //return _carDal.GetAll(c => c.BrandId == id);
        }


        public IDataResult<List<Car>> GetAllByModelYear(int year)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ModelYear == year), Messages.CarsListedByModelYear);
            //return _carDal.GetAll(c => c.ModelYear == year);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id), Messages.CarListedById);
           //return _carDal.Get(c => c.Id == id);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
            //return _carDal.GetCarDetails();
        }

        public IResult Updated(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.CarUpdated);
                //Console.WriteLine("Araba başarıyla güncellendi.");
            }
            return new ErrorResult(Messages.CarNameInvalid);
            
        }

        //List<Car> ICarService.GetAll()
        //{
        //    return _carDal.GetAll();


        //}
    }
}
