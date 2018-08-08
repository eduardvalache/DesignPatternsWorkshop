using MarvelApp.Ex2.CQRS.CommandHandlers;
using MarvelApp.Ex2.CQRS.Models.Command;
using MarvelApp.Ex2.CQRS.Models.Query;
using MarvelApp.Ex2.CQRS.QueryHandlers;
using Microsoft.AspNetCore.Mvc;

namespace MarvelApp.Ex2.API.Controllers
{
    [Route("api/battleResult")]
    public class BattleResult : Controller
    {
        private readonly IQueryDispatcher queryDispatcher;
        private readonly ICommandDispatcher commandDispatcher;

        public BattleResult(IQueryDispatcher queryDispatcher,
            ICommandDispatcher commandDispatcher)
        {
            this.queryDispatcher = queryDispatcher;
            this.commandDispatcher = commandDispatcher;
        }

        [HttpGet]
        public IActionResult Get(string superHero, string villain, int battlegroundId)
        {
            var query = new GetWinnerQuery(superHero, villain, battlegroundId);
            var winner = queryDispatcher.Execute<GetWinnerQuery, GetWinnerQueryResult>(query);

            return new OkObjectResult(winner);
        }

        [HttpPost]
        public IActionResult Add(string winnerAlias)
        {
            var command = new AddWinnerCommand(winnerAlias);
            commandDispatcher.Execute(command);

            return new OkResult();
        }
    }
}


