namespace WorkshopExample.BoundedContext.TrainTravellerCheckService
{
    public class Traveller
    {
        public string Id { get; private set; }

        public string Name { get; private set; } 

        public string LastName { get; private set; }

        public string Address { get; private set; }

        public Ticket Ticket { get; private set; } 
    }
}
