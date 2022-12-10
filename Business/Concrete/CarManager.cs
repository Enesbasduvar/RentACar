using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
		public IDataResult<List<Car>> GetAll()
		{
			return new DataResult<List<Car>>(_carDal.GetAll(), true, Messages.CarListed);
		}

		public IResult Add(Car car)
		{
			if (car.CarName.Length < 2)
			{
				return new ErrorResult(Messages.CarNameInvalid);
			}

			if (car.DailyPrice < 0)
			{
				return new ErrorResult(Messages.CarPriceInvalid);
			}
			_carDal.Add(car);
			return new SuccessResult(Messages.CarAdded);
		}


		public IResult Update(Car car)
		{
			_carDal.Update(car);
			return new SuccessResult();
		}

		public IResult Delete(Car car)
		{
			_carDal.Delete(car);
			return new SuccessResult();
		}

		public IDataResult<Car> GetById(int id)
		{
			return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
		}

		public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
		{
			return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
		}

		public IDataResult<List<Car>> GetCarsByColorId(int colorId)
		{
			return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
		}

		public IDataResult<List<CarDetailDto>> GetCarDetails()
		{
			return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
		}
	}
}