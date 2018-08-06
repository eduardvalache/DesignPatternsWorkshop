using MarvelApp.Domain.SharedKernel;

namespace MarvelApp.Domain.Entities
{
    public class Battleground : BaseEntity, IAggregateRoot
    {
        public Battleground(int id, string name, bool isEvil, bool isGood)
        {
            Id = id;
            Name = name;
            IsEvil = isEvil;
            IsGood = isGood;
        }

        public string Name { get; }
        
        public bool IsEvil { get; }

        public bool IsGood { get; }
    }
}
