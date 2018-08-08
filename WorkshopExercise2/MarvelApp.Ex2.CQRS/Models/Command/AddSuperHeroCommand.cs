using MarvelApp.Ex2.Domain.Entities;

namespace MarvelApp.Ex2.CQRS.Models.Command
{
    public class AddSuperHeroCommand : ICommand
    {
        public AddSuperHeroCommand(SuperHero superHero)
        {
            SuperHero = superHero;
        }

        public SuperHero SuperHero { get; set; }
    }
}