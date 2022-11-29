using System;
using System.Runtime.CompilerServices;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CarTest();
			BrandTest();
			ColorTest();
			CarManager carManager = new CarManager(new EfCarDal());
			foreach (var carDetail in carManager.GetCarDetails())
			{
				Console.WriteLine($"{carDetail.BrandName} {carDetail.CarName} {carDetail.ColorName} {carDetail.DailyPrice } tl");
			}

			carManager.GetCarDetails();
		}

		private static void ColorTest()
		{
			ColorManager colorManager = new ColorManager(new EfColorDal());
			colorManager.Add(new Color { ColorName = "Black" });
			//foreach (var color in colorManager.GetAll())
			//{
			//	Console.WriteLine(color.ColorName);
			//}

			//colorManager.Update(new Color { Id = 1, ColorName = "Red" });
			//foreach (var color in colorManager.GetAll())
			//{
			//	Console.WriteLine(color.ColorName);
			//}

			//colorManager.Delete(new Color { Id = 1 });
			//foreach (var color in colorManager.GetAll())
			//{
			//	Console.WriteLine(color.ColorName);
			//}
		}

		private static void BrandTest()
		{
			BrandManager brandManager = new BrandManager(new EfBrandDal());
			brandManager.Add(new Brand { BrandName = "Toyota" });
			//foreach (var brand in brandManager.GetAll())
			//{
			//	Console.WriteLine(brand.BrandName);
			//}

			//brandManager.Update(new Brand { Id = 1, BrandName = "BMW" });
			//foreach (var brand in brandManager.GetAll())
			//{
			//	Console.WriteLine(brand.BrandName);
			//}

			//brandManager.Delete(new Brand { Id = 1 });
			//foreach (var brand in brandManager.GetAll())
			//{
			//	Console.WriteLine(brand.BrandName);
			//}
		}

		private static void CarTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());

			carManager.Add(new Car { BrandId = 1, ColorId = 1,CarName = "Corolla",DailyPrice = 700, ModelYear = 2018});

			//foreach (var car in carManager.GetAll())
			//{
			//	Console.WriteLine($"{car.Id} {car.ModelYear} model {car.DailyPrice} tl");
			//}

			//carManager.Add(new Car { BrandId = 2, ColorId = 4, DailyPrice = 900, ModelYear = 2020 });
			//foreach (var car in carManager.GetAll())
			//{
			//	Console.WriteLine($"{car.Id} {car.ModelYear} model {car.DailyPrice} tl");
			//}
			//carManager.Update(new Car { Id = 1, ColorId = 2, ModelYear = 2015, DailyPrice = 500 });
			//carManager.Delete(new Car { Id = 2 });

			//foreach (var car in carManager.GetAll())
			//{
			//	Console.WriteLine($"{car.Id} {car.ModelYear} model {car.DailyPrice} tl");
			//}


		}
	}
}
