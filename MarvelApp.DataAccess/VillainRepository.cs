using MarvelApp.Domain.Entities;

namespace MarvelApp.DataAccess
{
    public class VillainRepository : IRepository<Villain>
    {
        public Villain GetByAlias(string villainName)
        {
            throw new System.NotImplementedException();
        }
    }
}
