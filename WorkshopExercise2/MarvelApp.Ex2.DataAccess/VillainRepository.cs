using MarvelApp.Ex2.DataAccess.Contracts;
using MarvelApp.Ex2.Domain.Entities;

namespace MarvelApp.Ex2.DataAccess
{
    public class VillainRepository : IVillainRepository
    {
        private readonly MarvelContext context;

        public VillainRepository(MarvelContext context)
        {
            this.context = context;
        }

        public Villain GetByAlias(string villainName)
        {
            return context.Villains.Find(x => x.Alias.ToLower() == villainName.ToLower());
        }

        public void Add(Villain villain)
        {
            context.Villains.Add(villain);
        }

        public Villain GetById(int id)
        {
            return context.Villains.Find(v => v.Id == id);
        }
    }
}