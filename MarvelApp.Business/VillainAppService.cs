using MarvelApp.DataAccess;
using MarvelApp.Domain.Entities;

namespace MarvelApp.Business
{
    public class VillainAppService
    {
        private readonly VillainRepository villainRepository;

        public VillainAppService()
        {
            villainRepository = new VillainRepository();
        }

        public void Add(Villain villain)
        {
            villainRepository.Add(villain);
        } 
    }
}
