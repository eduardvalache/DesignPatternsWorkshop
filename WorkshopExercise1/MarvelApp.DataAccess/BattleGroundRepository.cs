using System.Collections.Generic;
using MarvelApp.Domain.Entities;

namespace MarvelApp.DataAccess
{
    public class BattleGroundRepository : IRepository<Battleground>
    {
        private readonly List<Battleground> battlegroundsList;

        public BattleGroundRepository()
        {
            battlegroundsList = new List<Battleground>
            {
                new Battleground(1, "New York", false, true),
                new Battleground(2, "Asgard", true, false)
            };
        }

        public Battleground GetById(int battlegroundId)
        {
            return battlegroundsList.Find(x => x.Id == battlegroundId);
        }
    }
}
