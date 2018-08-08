using MarvelApp.Ex2.Domain.SharedKernel;

namespace MarvelApp.Ex2.Domain.ValueObjects
{
    public class SuperPower : ValueObject
    {
        public SuperPower(string name, string category, int strengthClass, int strength)
        {
            Name = name;
            Category = category;
            StrengthClass = strengthClass;
            Strength = strength;
        }

        public string Name { get; }

        public string Category { get; }

        public int Strength { get; private set; }

        public int StrengthClass { get; }

        public void IncreasePower()
        {
            Strength += 50;
        }
    }
}