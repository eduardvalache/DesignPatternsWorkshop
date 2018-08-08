using System.Collections.Generic;
using MarvelApp.Ex2.Domain.Entities;
using MarvelApp.Ex2.Domain.ValueObjects;

namespace MarvelApp.Ex2.DataAccess
{
    public class MarvelContext
    {
        public List<SuperHero> SuperHeroes;
        public List<Villain> Villains;
        public List<Battleground> Battlegrounds;

        public MarvelContext()
        {
            Seed();
        }

        public void Seed()
        {
            SuperHeroes = new List<SuperHero>
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

            Villains = new List<Villain>
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

            Battlegrounds = new List<Battleground>
            {
                new Battleground(1, "New York", false, true),
                new Battleground(2, "Asgard", true, false)
            };
        }
    }
}
