using MarvelApp.DataAccess;
using MarvelApp.Domain.Entities;
using MarvelApp.Domain.SharedKernel;

// ReSharper disable NotAccessedField.Local
// ReSharper disable once InconsistentNaming

namespace MarvelApp.DomainServices
{
    public class FightDomainService
    {
        private readonly BattleGroundRepository battlegroundRepository;

        public FightDomainService()
        {
            battlegroundRepository = new BattleGroundRepository();
        }

        public BaseEntity Fight(SuperHero superHero, Villain villan, int battlegroundId)
        {
            var superHeroStrength = superHero.GetTotalPower();
            var villainStrength = villan.GetTotalPower();

            var currentBattleground = battlegroundRepository.GetById(battlegroundId);

            if (currentBattleground.IsGood)
            {
                superHeroStrength += 100;
            }
            else if (currentBattleground.IsEvil)
            {
                villainStrength += 100;
            }

            return superHeroStrength > villainStrength ? (BaseEntity) superHero : villan;
        }
    }
}
