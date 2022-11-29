using System.Collections.Generic;
using Core.DataAccess;
using DataAccess.DTOs;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	public interface ICarDal : IEntityRepository<Car>
	{
		List<CarDetailDto> GetCarDetails();
	}
}