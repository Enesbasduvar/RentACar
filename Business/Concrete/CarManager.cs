﻿using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;

namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		private ICarDal _carDal;

		public CarManager(ICarDal carDal)
		{
			_carDal = carDal;
		}
		public List<Car> GetAll()
		{
			return _carDal.GetAll();
		}

		public void Add(Car car)
		{
			if (car.DailyPrice > 0 && car.CarName.Length >= 2)
			{
				_carDal.Add(car);
			}
		}

		public void Update(Car car)
		{
			_carDal.Update(car);
		}

		public void Delete(Car car)
		{
			_carDal.Delete(car);
		}

		public Car GetById(int id)
		{
			return _carDal.Get(c => c.Id == id);
		}

		public List<Car> GetCarsByBrandId(int brandId)
		{
			return _carDal.GetAll(c => c.BrandId == brandId);
		}

		public List<Car> GetCarsByColorId(int colorId)
		{
			return _carDal.GetAll(c => c.ColorId == colorId);
		}

		public List<CarDetailDto> GetCarDetails()
		{
			return _carDal.GetCarDetails();
		}
	}
}