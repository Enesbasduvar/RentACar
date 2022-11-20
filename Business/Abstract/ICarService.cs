using System.Collections.Generic;
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
	}
}