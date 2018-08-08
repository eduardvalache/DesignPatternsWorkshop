using MarvelApp.Ex2.Domain.Entities;
using MarvelApp.Ex2.Domain.SharedKernel;

namespace MarvelApp.Ex2.DomainServices
{
    public interface IFightDomainService
    {
        BaseEntity Fight(SuperHero superHero, Villain villan, Battleground battleground);
    }
}
