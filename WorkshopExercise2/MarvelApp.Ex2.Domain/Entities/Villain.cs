using System.Collections.Generic;
using MarvelApp.Ex2.Domain.SharedKernel;
using MarvelApp.Ex2.Domain.ValueObjects;

namespace MarvelApp.Ex2.Domain.Entities
{
    public class Villain : BaseEntity, IAggregateRoot
    {
        public Villain(string realName, string alias, ICollection<SuperPower> superPowersList)
        {
            RealName = realName;
            Alias = alias;
            SuperPowersList = superPowersList;
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