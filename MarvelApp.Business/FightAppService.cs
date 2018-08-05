using System;
using MarvelApp.DataAccess;
using MarvelApp.Domain;
using MarvelApp.DomainServices;

namespace MarvelApp.Business
{
    public class FightAppService
    {
        private readonly SuperHeroRepository superHeroRepository;

        private readonly VillainRepository villainRepository;

        private readonly FightingDomainService fightingDomainService;

        public bool GoodSideWon(string superHeroName, string villainName, int battlegroundId)
        {
            var superHero = superHeroRepository.GetByAlias(superHeroName);

            var villain = villainRepository.GetByAlias(villainName);

            var winner = fightingDomainService.GetIntoFight(superHero, villain, battlegroundId);

            if (winner is SuperHero)
            {
                return true;
            }

            return false;
        }
    }
}
