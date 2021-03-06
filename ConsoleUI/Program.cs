﻿using Business.Concrete;
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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());



            Console.WriteLine(" ModelYear - BrandName - Description - ColorName");
            var result = carManager.GetCarDetails();
            if (result.Success==true)
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
            var resultt = brandManager.GetAll();
            if (resultt.Success==true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
            Console.WriteLine("Renk seçenekleri");
            var resulttt = colorManager.GetAll();
            if (resulttt.Success==true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
            


            

            
            

        }
    }
}
