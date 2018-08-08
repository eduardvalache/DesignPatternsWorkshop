using MarvelApp.Ex2.CQRS.Models.Command;

namespace MarvelApp.Ex2.CQRS.CommandHandlers
{
    public interface ICommandDispatcher
    {
        void Execute<TCommand>(TCommand command) where TCommand : ICommand;
    }
}