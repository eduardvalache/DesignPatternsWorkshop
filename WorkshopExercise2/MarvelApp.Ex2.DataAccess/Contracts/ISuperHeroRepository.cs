using MarvelApp.Ex2.Domain.Entities;

namespace MarvelApp.Ex2.DataAccess.Contracts
{
    public interface ISuperHeroRepository : IRepository<SuperHero>
    {
        SuperHero GetByAlias(string alias);
    }
}