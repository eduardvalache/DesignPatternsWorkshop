using WorkshopExample.EntitiesAndValueObjects.SharedKernel;

namespace WorkshopExample._4._AggregateAndAggregateRoots
{
    public class Location : BaseEntity, IAggregateRoot
    {
        public Location(string country, string city, string code)
        {
            Country = country;
            City = city;
            Code = code;
        }

        public string Country { get; }

        public string City { get; }

        public string Code { get;}
    }
}
