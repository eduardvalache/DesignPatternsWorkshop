using System.Collections.Generic;
using MarvelApp.Domain.SharedKernel;
using MarvelApp.Domain.ValueObjects;

namespace MarvelApp.Domain
{
    public class SuperHero : BaseEntity, IAggregateRoot
    {
        public string RealName { get; }

        public string CharacterName { get; }

        public ICollection<SuperPower> SuperPowersList { get; }

        public int GetTotalPower()
        {
            var totalPower = 0;

            foreach (var superPower in SuperPowersList)
            {
                totalPower = superPower.StrengthClass * superPower.Strength;
            }

            return totalPower;
        }

    }
}
