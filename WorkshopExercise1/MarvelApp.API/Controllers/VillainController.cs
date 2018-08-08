using MarvelApp.Business;
using MarvelApp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
// ReSharper disable InconsistentNaming

namespace MarvelApp.API.Controllers
{
    public class VillainController
    {
        private readonly VillainAppService villainAppService;

        public VillainController()
        {
            villainAppService = new VillainAppService();
        }

        public IActionResult Post(Villain villan)
        {
            villainAppService.Add(villan);

            return new OkResult();
        }
    }
}
