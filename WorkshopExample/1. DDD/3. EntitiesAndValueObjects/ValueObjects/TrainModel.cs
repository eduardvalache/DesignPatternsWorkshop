using System;
using WorkshopExample.EntitiesAndValueObjects.SharedKernel;

namespace WorkshopExample.EntitiesAndValueObjects.ValueObjects
{
    public class TrainModel : ValueObject
    {
        public string Company { get; set; }

        public string Model { get; set; }

        public DateTime FabricationDate { get; set; }
    }
}
