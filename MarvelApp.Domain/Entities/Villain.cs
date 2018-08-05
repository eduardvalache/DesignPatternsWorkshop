using System.Collections.Generic;
using MarvelApp.Domain.SharedKernel;
using MarvelApp.Domain.ValueObjects;

namespace MarvelApp.Domain.Entities
{
    public class Villain : BaseEntity, IAggregateRoot
    {
        public Villain(string realName, string @alias)
        {
            RealName = realName;
            Alias = alias;
        }

        public string RealName { get; }

        public string Alias { get; }

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
