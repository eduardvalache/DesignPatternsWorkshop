using MarvelApp.Business;
using Microsoft.AspNetCore.Mvc;
// ReSharper disable InconsistentNaming

namespace MarvelApp.API.Controllers
{
    [Route("api/battleResult")]
    public class BattleResult : Controller
    {
        private readonly FightAppService fightAppService;

        public BattleResult()
        {
            fightAppService = new FightAppService();
        }

        [HttpGet]
        public IActionResult Get(string superHero, string villain, int battlegroundId)
        {
            var winner = fightAppService.GetWinner(superHero, villain, battlegroundId);
            
            return new OkObjectResult(winner);
        }

        [HttpPost]
        public IActionResult Add(string winnerAlias)
        {
            fightAppService.AddWinner(winnerAlias);

            return new OkResult();
        }
    }
}


