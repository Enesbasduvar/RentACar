using System.Collections.Generic;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryColorDal
	{
		private List<Color> _colors;

		public InMemoryColorDal()
		{
			_colors = new List<Color>()
			{
				new Color{Id = 1,ColorName = "Black"},
				new Color{Id = 2,ColorName = "White"},
				new Color{Id = 3,ColorName = "Red"},
			};
		}
	}
}