using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Available Cars");
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.Getall())
            {
                Console.WriteLine(car.Description);


            }
        }
    }
}
