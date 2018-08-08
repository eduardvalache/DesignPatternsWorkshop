using MarvelApp.Ex2.Domain.Entities;
using MarvelApp.Ex2.Domain.SharedKernel;

namespace MarvelApp.Ex2.DomainServices
{
    public class FightDomainService : IFightDomainService
    {
        public BaseEntity Fight(SuperHero superHero, Villain villan, Battleground battleground)
        {
            var superHeroStrength = superHero.GetTotalPower();
            var villainStrength = villan.GetTotalPower();

            if (battleground.IsGood)
            {
                superHeroStrength += 100;
            }
            else if (battleground.IsEvil)
            {
                villainStrength += 100;
            }

            return superHeroStrength > villainStrength ? (BaseEntity)superHero : villan;
        }
    }
}