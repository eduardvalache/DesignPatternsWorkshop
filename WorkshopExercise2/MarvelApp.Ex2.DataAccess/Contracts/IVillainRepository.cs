using MarvelApp.Ex2.Domain.Entities;

namespace MarvelApp.Ex2.DataAccess.Contracts
{
    public interface IVillainRepository : IRepository<Villain>
    {
        Villain GetByAlias(string alias);
    }
}