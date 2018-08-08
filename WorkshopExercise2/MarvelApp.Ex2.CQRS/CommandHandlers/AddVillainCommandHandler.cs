using MarvelApp.Ex2.CQRS.Models.Command;
using MarvelApp.Ex2.DataAccess.Contracts;

namespace MarvelApp.Ex2.CQRS.CommandHandlers
{
    public class AddVillainCommandHandler : ICommandHandler<AddVillainCommand>
    {
        private readonly IVillainRepository villainRepository;

        public AddVillainCommandHandler(IVillainRepository villainRepository)
        {
            this.villainRepository = villainRepository;
        }

        public void Execute(AddVillainCommand command)
        {
            villainRepository.Add(command.Villain);
        }
    }
}