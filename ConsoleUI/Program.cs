using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.ModelYear + "/" + car.BrandName + "/" + car.Description + "/" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
            
                
            

            Console.WriteLine("Stokta olan markalar");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("Renk seçenekleri");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }

            
            

        }
    }
}
