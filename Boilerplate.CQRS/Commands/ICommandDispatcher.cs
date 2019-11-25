using System.Threading.Tasks;

namespace Boilerplate.CQRS.Commands
{
    public interface ICommandDispatcher
    {
        Task DispatchAsync<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
