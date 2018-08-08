using System.Collections.Generic;
using MarvelApp.Ex2.Domain.SharedKernel;
using MarvelApp.Ex2.Domain.ValueObjects;

namespace MarvelApp.Ex2.Domain.Entities
{
    public class SuperHero : BaseEntity, IAggregateRoot
    {
        public SuperHero(string realName, string alias, ICollection<SuperPower> superPowersList)
        {
            RealName = realName;
            SuperPowersList = superPowersList;
            Alias = alias;
            Winnings = 0;
        }

        public string RealName { get; }

        public int Winnings { get; private set; }

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


        public void IncreaseWinnings()
        {
            Winnings += 1;

            foreach (var superPower in SuperPowersList)
            {
                superPower.IncreasePower();
            }
        }
    }
}