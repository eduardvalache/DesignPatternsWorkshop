using MarvelApp.Ex2.Domain.Entities;

namespace MarvelApp.Ex2.CQRS.Models.Command
{
    public class AddVillainCommand : ICommand
    {
        public Villain Villain { get; set; }

        public AddVillainCommand(Villain villain)
        {
            Villain = villain;
        }
    }
}