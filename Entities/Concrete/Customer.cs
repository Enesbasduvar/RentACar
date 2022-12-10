using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }

        public User User { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}