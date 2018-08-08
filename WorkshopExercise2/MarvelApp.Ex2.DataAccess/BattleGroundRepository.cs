using MarvelApp.Ex2.DataAccess.Contracts;
using MarvelApp.Ex2.Domain.Entities;

namespace MarvelApp.Ex2.DataAccess
{
    public class BattleGroundRepository : IRepository<Battleground>
    {
        private readonly MarvelContext context;

        public BattleGroundRepository(MarvelContext context)
        {
            this.context = context;
        }

        public Battleground GetById(int id)
        {
            return context.Battlegrounds.Find(x => x.Id == id);
        }

        public void Add(Battleground battleground)
        {
            context.Battlegrounds.Add(battleground);
        }
    }
}