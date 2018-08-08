using MarvelApp.DataAccess;
using MarvelApp.Domain.Entities;
// ReSharper disable InconsistentNaming

namespace MarvelApp.Business
{
    public class SuperHeroAppService
    {
        private readonly SuperHeroRepository superHeroRepository;

        public SuperHeroAppService()
        {
            superHeroRepository = new SuperHeroRepository();
        }

        public void Add(SuperHero superHero)
        {
            superHeroRepository.Add(superHero);
        }
    }
}
