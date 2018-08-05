using WorkshopExample.EntitiesAndValueObjects.SharedKernel;
using WorkshopExample.EntitiesAndValueObjects.ValueObjects;

namespace WorkshopExample.EntitiesAndValueObjects.Entities
{
    public class Train : BaseEntity
    {
        public Train(string alias, TrainModel model, int maxCapacity, string lineId)
        {
            Alias = alias;
            Model = model;
            MaxCapacity = maxCapacity;
            LineId = lineId;
            CurrentCapacity = 0;
        }

        public string Alias { get; }

        public TrainModel Model { get; } 

        public string LineId { get; }

        public int MaxCapacity { get;  }

        public int CurrentCapacity { get; private set; }

        public bool DoesNotExceedCapacityLimit(int requestedSeatsCount)
        {
            return MaxCapacity < CurrentCapacity;
        }

        public void BookSeats(int requestedSeatsCount)
        {
            CurrentCapacity += requestedSeatsCount;
        }
    }
}
