// ReSharper disable UseNullPropagation

using System.Runtime.InteropServices.ComTypes;
// ReSharper disable InconsistentNaming

namespace WorkshopExample._5._ApplicationAndDomainServices
{
    public class TripAppService
    {
        private readonly TripRepository tripRepository;

        private readonly TicketDomainService ticketDomainService;

        public TripAppService(TripRepository tripRepository, TicketDomainService ticketDomainService)
        {
            this.tripRepository = tripRepository;
            this.ticketDomainService = ticketDomainService;
        }

        public Ticket ReserveTrip(string sourceLocationId, string destinationLocationId, string seatsToReserveCount)
        {
            var foundTrip = tripRepository.SearchTrip(sourceLocationId, destinationLocationId);

            if (foundTrip != null)
            {
                foundTrip.ReserveSeats(seatsToReserveCount);

                var basePrice = foundTrip.GetBasePrice();
                var distance = foundTrip.GetDistance();

                var additionalTaxes = ticketDomainService.CalculateTax(basePrice, destinationLocationId, distance);

                tripRepository.SaveChanges();

                return new Ticket(basePrice + additionalTaxes);
            }

            return null;
        }
    }
}
