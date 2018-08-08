using MarvelApp.Ex2.CQRS.Models.Command;

namespace MarvelApp.Ex2.CQRS.CommandHandlers
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Execute(TCommand command);
    }
}