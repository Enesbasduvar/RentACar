using System.Collections.Generic;
using DataAccess.DTOs;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ICarService
	{
		List<Car> GetAll();
		void Add(Car car);
		void Update(Car car);
		void Delete(Car car);
		Car GetById(int id);

		List<Car> GetCarsByBrandId(int brandId);
		List<Car> GetCarsByColorId(int colorId);
		List<CarDetailDto> GetCarDetails();

	}
}