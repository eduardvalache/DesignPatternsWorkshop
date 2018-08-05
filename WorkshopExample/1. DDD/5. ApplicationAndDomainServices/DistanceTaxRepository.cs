namespace WorkshopExample._5._ApplicationAndDomainServices
{
    public class DistanceTaxRepository
    {
        public int GetTaxPercentageByDistance(int distance)
        {
            if (distance < 100)
            {
                return 30;
            }

            return 15;
        }
    }
}
