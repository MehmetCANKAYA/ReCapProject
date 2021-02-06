using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())            
                Console.WriteLine($"{car.BrandId} {car.ColorId} {car.Description} {car.DailyPrice} ");                 
            

            Console.WriteLine("-----------------------------");
            foreach (var car in carManager.GetAllByColor(2))            
                Console.WriteLine($"{car.BrandId} {car.ColorId} {car.Description} {car.DailyPrice} ");
            

            carManager.Add(new Entities.Concrete.Car { CarId = 9, BrandId = 2, ColorId = 1, Description = "yeni Kayıt", DailyPrice = 134000, year = "2020" });

            Console.WriteLine((carManager.Get(9)).Description);
            Console.WriteLine("-----------------------------");
            foreach (var car in carManager.GetAll())            
                Console.WriteLine($"{car.BrandId} {car.ColorId} {car.Description} {car.DailyPrice} ");
            

        }
    }
}
