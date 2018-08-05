using WorkshopExample.EntitiesAndValueObjects.SharedKernel;

namespace WorkshopExample._4._AggregateAndAggregateRoots
{
    public class Passenger : BaseEntity
    {
        public Passenger(int age, string firstName, string lastName)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public int Age { get; }
    }
}
