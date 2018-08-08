using MarvelApp.Ex2.CQRS.Models.Query;
using MarvelApp.Ex2.DataAccess.Contracts;
using MarvelApp.Ex2.Domain.Entities;
using MarvelApp.Ex2.DomainServices;

namespace MarvelApp.Ex2.CQRS.QueryHandlers
{
    public class GetWinnerQueryHandler : IQueryHandler<GetWinnerQuery, GetWinnerQueryResult>
    {
        private readonly ISuperHeroRepository superHeroRepository;
        private readonly IVillainRepository villainRepository;
        private readonly IRepository<Battleground> battlegroundRepository;
        private readonly IFightDomainService fightDomainService;

        public GetWinnerQueryHandler(ISuperHeroRepository superHeroRepository,
            IVillainRepository villainRepository,
            IRepository<Battleground> battlegroundRepository,
            IFightDomainService fightDomainService)
        {
            this.superHeroRepository = superHeroRepository;
            this.villainRepository = villainRepository;
            this.battlegroundRepository = battlegroundRepository;
            this.fightDomainService = fightDomainService;
        }

        public GetWinnerQueryResult Execute(GetWinnerQuery query)
        {
            var superHero = superHeroRepository.GetByAlias(query.Superhero);
            var villain = villainRepository.GetByAlias(query.Villain);
            var battleground = battlegroundRepository.GetById(query.BattlegroundId);

            var winner = fightDomainService.Fight(superHero, villain, battleground);

            return new GetWinnerQueryResult(winner.Alias);
        }
    }
}