using MarvelApp.Domain.SharedKernel;

namespace MarvelApp.Domain.Entities
{
    public class Battleground : BaseEntity, IAggregateRoot
    {
        public Battleground(string name, bool isEvil, bool isGood)
        {
            Name = name;
            IsEvil = isEvil;
            IsGood = isGood;
        }

        public string Name { get; }
        
        public bool IsEvil { get; }

        public bool IsGood { get; }
    }
}
