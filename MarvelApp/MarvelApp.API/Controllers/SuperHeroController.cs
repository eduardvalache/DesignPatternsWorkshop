using MarvelApp.Business;
using MarvelApp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MarvelApp.API.Controllers
{
    [Route("api/superhero")]
    public class SuperHeroController
    {
        private readonly SuperHeroAppService superHeroAppService;

        public SuperHeroController()
        {
            superHeroAppService = new SuperHeroAppService();
        }

        public IActionResult Post(SuperHero superHero)
        {
             superHeroAppService.Add(superHero);

            return new OkResult();
        }
    }
}
