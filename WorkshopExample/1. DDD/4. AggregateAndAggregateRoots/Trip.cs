using System.Collections.Generic;
using WorkshopExample.EntitiesAndValueObjects.SharedKernel;

namespace WorkshopExample._4._AggregateAndAggregateRoots
{
    public class Trip : BaseEntity, IAggregateRoot
    {
        public Trip(string identifier, Location sourceLocation, Location destinationLocation, ICollection<Passenger> passengersList)
        {
            Identifier = identifier;
            SourceLocation = sourceLocation;
            DestinationLocation = destinationLocation;
            PassengersList = passengersList;
        }

        public string Identifier { get; }

        public Location SourceLocation { get; }

        public Location DestinationLocation { get; }

        public ICollection<Passenger> PassengersList { get; }

        public void AddPassenger(Passenger passenger)
        {
            // check if passengers count fits, then
            PassengersList.Add(passenger);
        }
    }
}
