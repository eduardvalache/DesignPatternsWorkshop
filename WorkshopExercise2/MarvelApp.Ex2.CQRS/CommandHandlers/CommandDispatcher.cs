using Autofac;
using MarvelApp.Ex2.CQRS.Models.Command;

namespace MarvelApp.Ex2.CQRS.CommandHandlers
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IComponentContext container;

        public CommandDispatcher(IComponentContext container)
        {
            this.container = container;
        }

        public void Execute<TCommand>(TCommand command) where TCommand : ICommand
        {
            var commandHandler = container.Resolve<ICommandHandler<TCommand>>();

            commandHandler.Execute(command);
        }
    }
}