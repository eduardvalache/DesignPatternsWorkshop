using MarvelApp.Ex2.CQRS.Models.Command;
using MarvelApp.Ex2.DataAccess.Contracts;

namespace MarvelApp.Ex2.CQRS.CommandHandlers
{
    public class AddSuperHeroCommandHandler : ICommandHandler<AddSuperHeroCommand>
    {
        private readonly ISuperHeroRepository superHeroRepository;

        public AddSuperHeroCommandHandler(ISuperHeroRepository superHeroRepository)
        {
            this.superHeroRepository = superHeroRepository;
        }

        public void Execute(AddSuperHeroCommand command)
        {
            superHeroRepository.Add(command.SuperHero);
        }
    }
}