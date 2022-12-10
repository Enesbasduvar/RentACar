using System.Collections;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
	public class Color:IEntity
	{
		public int Id { get; set; }
		public string ColorName { get; set; }

		public ICollection<Car> Cars { get; set; }
	}
}