namespace MarvelApp.Domain.ValueObjects
{
    public class SuperPower : ValueObject
    {
        public SuperPower(string name, string category, string power, int strengthClass, int strength)
        {
            Name = name;
            Category = category;
            StrengthClass = strengthClass;
            Strength = strength;
        }

        public string Name { get; }

        public string Category { get; }

        public int Strength { get; }

        public int StrengthClass { get; }
    }
}
