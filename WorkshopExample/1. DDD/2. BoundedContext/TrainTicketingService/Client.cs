namespace WorkshopExample.BoundedContext.TrainTicketingService
{
    public class Client
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public string LastName { get; private set; }

        public string Address { get; private set; }

        public Invoice Invoice { get; private set; }
    }
}
