using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCarDal : EfEntityrepositoryBase<Car, RentACarContext>, ICarDal
	{
		public List<CarDetailDto> GetCarDetails()
		{
			using (RentACarContext context = new RentACarContext())
			{
				var result = from c in context.Cars
							 join b in context.Brands
								 on c.BrandId equals b.Id
							 join color in context.Colors
								 on c.ColorId equals color.Id
							 select new CarDetailDto
							 {
								 CarName = c.CarName, BrandName = b.BrandName, ColorName = color.ColorName, DailyPrice = c.DailyPrice
							 };
				return result.ToList();
			}
		}
	}
}