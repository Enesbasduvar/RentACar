using System.Collections.Generic;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryBrandDal
	{
		private List<Brand> _brands;

		public InMemoryBrandDal()
		{
			_brands = new List<Brand>
			{
				new Brand{Id = 1,BrandName = "Audi"},
				new Brand{Id = 2,BrandName = "BMW"},
				new Brand{Id = 3,BrandName = "Renault"},
				new Brand{Id = 4,BrandName = "Fiat"},
				new Brand{Id = 5,BrandName = "Ford"},
			};
		}
	}
}