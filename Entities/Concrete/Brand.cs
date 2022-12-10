using System.Collections;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
	public class Brand:IEntity
	{
		public int Id { get; set; }
		public string BrandName { get; set; }

		public ICollection<Car> Cars { get; set; }
	}
}