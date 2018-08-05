using MarvelApp.Domain;

namespace MarvelApp.DataAccess
{
    public class SuperHeroRepository : IRepository<SuperHero>
    {
        public SuperHero GetByAlias(string superHeroName)
        {
            throw new System.NotImplementedException();
        }
    }
}
