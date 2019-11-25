using System.Threading.Tasks;

namespace Boilerplate.CQRS.Commands
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        Task HandleAsync(TCommand command);
    }
}
