using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("Brand Id'si 1 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetAllByBrandId("1"))
            {
                Console.WriteLine($"{car.Id}\t{colorManager.GetByColorId(car.ColorId).ColorName}\t\t{brandManager.GetByBrandId(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
            }

            Console.WriteLine("\n\nColor Id'si 2 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetAllByColorId(2))
            {
                Console.WriteLine($"{"car.CarId"}\t{colorManager.GetByColorId("car.ColorId").ColorName}\t\t{brandManager.GetByBrandId("car.BrandId").BrandName}\t\t{"car.ModelYear"}\t\t{"car.DailyPrice"}\t\t{"car.Description"}");
            }

            Console.WriteLine("\n\nId'si 2 olan araba: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            Car carById = carManager.GetById("2");
            Console.WriteLine($"{carById.Id}\t{colorManager.GetByColorId(carById.ColorId).ColorName}\t\t{brandManager.GetByBrandId(carById.BrandId).BrandName}\t\t{carById.ModelYear}\t\t{carById.DailyPrice}\t\t{carById.Description}");



            Console.WriteLine("\n");

            carManager.Add(new Car { BrandId = "1", ColorId = "2", DailyPrice = -300, ModelYear = 2021, Description = "Otomatik Dizel" });
            brandManager.Add(new Brand { BrandName = "a" });
        }
    }
}
