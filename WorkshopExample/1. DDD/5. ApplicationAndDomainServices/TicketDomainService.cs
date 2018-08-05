// ReSharper disable InconsistentNaming
namespace WorkshopExample._5._ApplicationAndDomainServices
{
    public class TicketDomainService
    {
        private readonly CountryTaxRepository countryTaxRepository;

        public readonly DistanceTaxRepository distanceTaxRepository;

        public TicketDomainService(CountryTaxRepository countryTaxRepository, DistanceTaxRepository distanceTaxRepository)
        {
            this.countryTaxRepository = countryTaxRepository;
            this.distanceTaxRepository = distanceTaxRepository;
        }

        public int CalculateTax(int initialCost, string countryId, int distance)
        {
            var countryTax = countryTaxRepository.GetTaxByCountryId(countryId);
            var distanceTax = distanceTaxRepository.GetTaxPercentageByDistance(distance);

            return initialCost + (initialCost * countryTax) + (initialCost * distanceTax);
        }
    }
}
