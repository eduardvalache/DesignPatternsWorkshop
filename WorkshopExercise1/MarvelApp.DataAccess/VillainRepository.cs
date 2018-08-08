using System.Collections.Generic;
using MarvelApp.Domain.Entities;
using MarvelApp.Domain.ValueObjects;

// ReSharper disable InconsistentNaming

namespace MarvelApp.DataAccess
{
    public class VillainRepository : IRepository<Villain>
    {
        private readonly List<Villain> villainStorage;

        public VillainRepository()
        {
            villainStorage = new List<Villain>
            {
                new Villain("Loki", "Loki", new List<SuperPower>
                {
                    new SuperPower("Asgardian", "Race", 10, 100),
                    new SuperPower("Intelligence", "Mental", 10, 50)
                }),
                new Villain("Thanos", "Thanos", new List<SuperPower>
                {
                    new SuperPower("Blast Power", "Power", 5, 100),
                    new SuperPower("Fligth", "Physic", 10, 50)
                })
            };
        }

        public Villain GetByAlias(string villainName)
        {
            return villainStorage.Find(x => x.Alias.ToLower() == villainName.ToLower());
        }

        public void Add(Villain villain)
        {
            villainStorage.Add(villain);
        }
    }
}
