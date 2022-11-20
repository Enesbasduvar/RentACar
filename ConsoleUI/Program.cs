using System;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

	        CarManager carManager = new CarManager(new InMemoryCarDal());

	        foreach (var car in carManager.GetAll())
	        {
		        Console.WriteLine($"{car.Id} {car.ModelYear} model {car.DailyPrice}tl");
	        }

            carManager.Add(new Car{Id = 6,BrandId = 4,ColorId = 1,ModelYear = 2020,DailyPrice = 900});

            carManager.Delete(carManager.GetById(3));

            carManager.Update(new Car{ Id = 1, BrandId = 4, ColorId = 1, DailyPrice = 300, ModelYear = 2015, Description = "" });

            Console.WriteLine("----------------------------------");
            foreach (var car in carManager.GetAll())
            {
	            Console.WriteLine($"{car.Id} {car.ModelYear} model {car.DailyPrice}tl");
            }
		}
    }
}
