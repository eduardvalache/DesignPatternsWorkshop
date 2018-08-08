using MarvelApp.Ex2.CQRS.Models.Command;
using MarvelApp.Ex2.DataAccess.Contracts;

namespace MarvelApp.Ex2.CQRS.CommandHandlers
{
    public class AddWinnerCommandHandler : ICommandHandler<AddWinnerCommand>
    {
        private readonly ISuperHeroRepository superHeroRepository;

        public AddWinnerCommandHandler(ISuperHeroRepository superHeroRepository)
        {
            this.superHeroRepository = superHeroRepository;
        }

        public void Execute(AddWinnerCommand command)
        {
            var superHero = superHeroRepository.GetByAlias(command.WinnerAlias);
            superHero?.IncreaseWinnings();
        }
    }
}