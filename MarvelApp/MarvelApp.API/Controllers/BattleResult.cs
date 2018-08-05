using MarvelApp.Business;
using Microsoft.AspNetCore.Mvc;

namespace MarvelApp.API.Controllers
{
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
            if (fightAppService.GoodSideWon(superHero, villain, battlegroundId))
            {
                return new OkResult();
            }

            return new BadRequestResult();
        }
    }
}
