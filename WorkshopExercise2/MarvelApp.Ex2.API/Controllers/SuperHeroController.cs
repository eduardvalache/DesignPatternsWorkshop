using MarvelApp.Ex2.CQRS.CommandHandlers;
using MarvelApp.Ex2.CQRS.Models.Command;
using MarvelApp.Ex2.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MarvelApp.Ex2.API.Controllers
{
    [Route("api/superhero")]
    public class SuperHeroController
    {
        private readonly ICommandDispatcher commandDispatcher;

        public SuperHeroController(ICommandDispatcher commandDispatcher)
        {
            this.commandDispatcher = commandDispatcher;
        }

        public IActionResult Post(SuperHero superHero)
        {
            var command = new AddSuperHeroCommand(superHero);
            commandDispatcher.Execute(command);

            return new OkResult();
        }
    }
}
