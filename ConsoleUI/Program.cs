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
			BrandTest();
			ColorTest();
			CarTest();
			CarDetailTest();
			UserTest();
			CustomerTest();
			RentalTest();
		}

		private static void RentalTest()
		{
			RentalManager rentalManager = new RentalManager(new EfRentalDal());
			rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.UtcNow });
			//rentalManager.Update(new Rental
			//{ Id = 1, CarId = 1, CustomerId = 1, RentDate = DateTime.UtcNow, ReturnDate = DateTime.Now });
			//var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Now });
			//if (result.Success)
			//{
			//	foreach (var rental in rentalManager.GetAll().Data)
			//	{
			//		Console.WriteLine($"{rental.CarId} {rental.CustomerId} {rental.RentDate}");
			//	}
			//}
			//else
			//{
			//	Console.WriteLine(result.Message);
			//}

			//rentalManager.Delete(new Rental { Id = 1 });

		}

		private static void CustomerTest()
		{
			CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
			customerManager.Add(new Customer { UserId = 1, CompanyName = "asdf" });
			customerManager.Update(new Customer { UserId = 1, CompanyName = "KadyrBilişim" });
			//foreach (var customer in customerManager.GetAll().Data)
			//{
			//	Console.WriteLine(customer.CompanyName);
			//}

			//customerManager.Delete(new Customer { UserId = 1 });
		}

		private static void UserTest()
		{
			UserManager userManager = new UserManager(new EfUserDal());
			userManager.Add(new User
			{ FirstName = "Kadir", LastName = "Kaya", Email = "kadirkaya@mail.com", Password = "123456" });
			//userManager.Update(new User { Id = 1, FirstName = "Kadir", LastName = "Kaya", Email = "kadirkaya@mail.com", Password = "qwerty" });
			//foreach (var user in userManager.GetAll().Data)
			//{
			//	Console.WriteLine($"{user.FirstName} {user.LastName} {user.Email} {user.Password}");
			//}

			//userManager.Delete(new User { Id = 1 });
		}

		private static void CarDetailTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			foreach (var carDetail in carManager.GetCarDetails().Data)
			{
				Console.WriteLine($"{carDetail.BrandName} {carDetail.CarName} {carDetail.ColorName} {carDetail.DailyPrice} tl");
			}
		}

		private static void ColorTest()
		{
			ColorManager colorManager = new ColorManager(new EfColorDal());
			colorManager.Add(new Color { ColorName = "Black" });
			foreach (var color in colorManager.GetAll().Data)
			{
				Console.WriteLine(color.ColorName);
			}

			//colorManager.Update(new Color { Id = 1, ColorName = "Red" });
			//foreach (var color in colorManager.GetAll().Data)
			//{
			//	Console.WriteLine(color.ColorName);
			//}

			//colorManager.Delete(new Color { Id = 1 });
			//foreach (var color in colorManager.GetAll().Data)
			//{
			//	Console.WriteLine(color.ColorName);
			//}
		}

		private static void BrandTest()
		{
			BrandManager brandManager = new BrandManager(new EfBrandDal());
			brandManager.Add(new Brand { BrandName = "Toyota" });
			foreach (var brand in brandManager.GetAll().Data)
			{
				Console.WriteLine(brand.BrandName);
			}

			//brandManager.Update(new Brand { Id = 1, BrandName = "BMW" });
			//foreach (var brand in brandManager.GetAll().Data)
			//{
			//	Console.WriteLine(brand.BrandName);
			//}

			//brandManager.Delete(new Brand { Id = 1 });
			//foreach (var brand in brandManager.GetAll().Data)
			//{
			//	Console.WriteLine(brand.BrandName);
			//}
		}

		private static void CarTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());

			carManager.Add(new Car { BrandId = 1, ColorId = 1, CarName = "Corolla", DailyPrice = 700, ModelYear = 2018 });

			foreach (var car in carManager.GetAll().Data)
			{
				Console.WriteLine($"{car.Id} {car.ModelYear} model {car.DailyPrice} tl");
			}

			//carManager.Add(new Car { BrandId = 2, ColorId = 4, DailyPrice = 900, ModelYear = 2020 });
			//foreach (var car in carManager.GetAll().Data)
			//{
			//	Console.WriteLine($"{car.Id} {car.ModelYear} model {car.DailyPrice} tl");
			//}
			//carManager.Update(new Car { Id = 1, ColorId = 2, ModelYear = 2015, DailyPrice = 500 });
			//carManager.Delete(new Car { Id = 1 });

			//foreach (var car in carManager.GetAll().Data)
			//{
			//	Console.WriteLine($"{car.Id} {car.ModelYear} model {car.DailyPrice} tl");
			//}
		}
	}
}
