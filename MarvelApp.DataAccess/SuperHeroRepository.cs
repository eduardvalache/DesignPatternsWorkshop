using System.Collections.Generic;
using MarvelApp.Domain;
using MarvelApp.Domain.Entities;
using MarvelApp.Domain.ValueObjects;
// ReSharper disable InconsistentNaming

namespace MarvelApp.DataAccess
{
    public class SuperHeroRepository : IRepository<SuperHero>
    {
        private readonly List<SuperHero> superHeroStorage;

        public SuperHeroRepository()
        {
            superHeroStorage = new List<SuperHero>
            {
                new SuperHero("Bruce Banner", "Hulk", new List<SuperPower>
                {
                    new SuperPower("Brute force", "Phisical", 5, 100)
                }),
                new SuperHero("Edward Stark", "IronMan", new List<SuperPower>
                {
                    new SuperPower("Costume", "Physical", 10, 100),
                    new SuperPower("Money", "Money", 5, 100)
                })
            };
        }

        public SuperHero GetByAlias(string superHeroName)
        {
            return superHeroStorage.Find(x => x.Alias.ToLower() == superHeroName.ToLower());
        }

        public void Add(SuperHero superHero)
        {
            superHeroStorage.Add(superHero);
        }
    }
}
