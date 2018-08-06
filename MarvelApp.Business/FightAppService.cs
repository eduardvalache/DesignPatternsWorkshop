using MarvelApp.DataAccess;
using MarvelApp.DomainServices;
// ReSharper disable InconsistentNaming

namespace MarvelApp.Business
{
    public class FightAppService
    {
        private readonly SuperHeroRepository superHeroRepository;

        private readonly VillainRepository villainRepository;

        private readonly FightDomainService fightingDomainService;

        public FightAppService()
        {
            superHeroRepository = new SuperHeroRepository();
            villainRepository = new VillainRepository();
            fightingDomainService = new FightDomainService();
        }

        public string GetWinner(string superHeroName, string villainName, int battlegroundId)
        {
            var superHero = superHeroRepository.GetByAlias(superHeroName);

            var villain = villainRepository.GetByAlias(villainName);

            var winner = fightingDomainService.Fight(superHero, villain, battlegroundId);

            return winner.Alias;
        }

        public void AddWinner(string winnerAlias)
        {
            var superHero = superHeroRepository.GetByAlias(winnerAlias);
                   
            superHero.IncreaseWinnings();
        }
    }
}
