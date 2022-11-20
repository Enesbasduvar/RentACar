using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
	    private List<Car> _cars;

	    public InMemoryCarDal()
	    {
		    _cars = new List<Car>()
		    {
                new Car{Id = 1,BrandId = 4,ColorId = 3 ,DailyPrice = 350, ModelYear = 2015, Description = ""},
                new Car{Id = 2,BrandId = 1,ColorId = 1 ,DailyPrice = 800, ModelYear = 2018, Description = ""},
                new Car{Id = 3,BrandId = 5,ColorId = 2 ,DailyPrice = 500, ModelYear = 2017, Description = ""},
                new Car{Id = 4,BrandId = 3,ColorId = 2 ,DailyPrice = 200, ModelYear = 2013, Description = ""},
                new Car{Id = 5,BrandId = 2,ColorId = 3 ,DailyPrice = 1000, ModelYear = 2018, Description = ""},
		    };
	    }
	    public List<Car> GetAll()
	    {
		    return _cars;
	    }

        public Car GetById(int id)
        {
            Car result = _cars.Find(c => c.Id == id);
            return result;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
	        throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
	        throw new NotImplementedException();
        }



        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
	        Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
			Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
		}
    }
}