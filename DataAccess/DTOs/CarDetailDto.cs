using Core.Entities;

namespace DataAccess.DTOs
{
	public class CarDetailDto:IDto
	{
		public int Id { get; set; }
		public string CarName { get; set; }
		public string BrandName { get; set; }
		public string ColorName { get; set; }
		public decimal DailyPrice { get; set; }
	}
}