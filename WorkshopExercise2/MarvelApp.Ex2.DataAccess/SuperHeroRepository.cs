using MarvelApp.Ex2.DataAccess.Contracts;
using MarvelApp.Ex2.Domain.Entities;

namespace MarvelApp.Ex2.DataAccess
{
    public class SuperHeroRepository : ISuperHeroRepository
    {
        private readonly MarvelContext context;

        public SuperHeroRepository(MarvelContext context)
        {
            this.context = context;
        }

        public SuperHero GetByAlias(string superHeroName)
        {
            return context.SuperHeroes.Find(x => x.Alias.ToLower() == superHeroName.ToLower());
        }

        public void Add(SuperHero superHero)
        {
            context.SuperHeroes.Add(superHero);
        }

        public SuperHero GetById(int id)
        {
            return context.SuperHeroes.Find(s => s.Id == id);
        }
    }
}