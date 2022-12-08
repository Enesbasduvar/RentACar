using System.Collections.Generic;
using Core.Utilities.Results;
using DataAccess.DTOs;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ICarService
	{
		IDataResult<List<Car>> GetAll();
		IResult Add(Car car);
		IResult Update(Car car);
		IResult Delete(Car car);
		IDataResult<Car> GetById(int id);

		IDataResult<List<Car>> GetCarsByBrandId(int brandId);
		IDataResult<List<Car>> GetCarsByColorId(int colorId);
		IDataResult<List<CarDetailDto>> GetCarDetails();

	}
}