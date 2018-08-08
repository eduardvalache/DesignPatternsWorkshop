using MarvelApp.Ex2.CQRS.CommandHandlers;
using MarvelApp.Ex2.CQRS.Models.Command;
using MarvelApp.Ex2.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MarvelApp.Ex2.API.Controllers
{
    public class VillainController
    {
        private readonly ICommandDispatcher commandDispatcher;

        public VillainController(ICommandDispatcher commandDispatcher)
        {
            this.commandDispatcher = commandDispatcher;
        }

        public IActionResult Post(Villain villan)
        {
            var command = new AddVillainCommand(villan);
            commandDispatcher.Execute(command);

            return new OkResult();
        }
    }
}
