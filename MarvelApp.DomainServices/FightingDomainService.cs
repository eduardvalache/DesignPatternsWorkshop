using MarvelApp.DataAccess;
using MarvelApp.Domain;
using MarvelApp.Domain.Entities;
// ReSharper disable NotAccessedField.Local
// ReSharper disable once InconsistentNaming

namespace MarvelApp.DomainServices
{
    public class FightingDomainService
    {
        private readonly BattleGroundRepository battlegroundRepository;

        public FightingDomainService()
        {
            battlegroundRepository = new BattleGroundRepository();
        }

        public BaseEntity GetIntoFight(SuperHero superHero, Villain villan, int battlegroundId)
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
