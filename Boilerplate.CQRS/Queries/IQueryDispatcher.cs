using System.Threading.Tasks;

namespace Boilerplate.CQRS.Queries
{
    public interface IQueryDispatcher
    {
        Task<TResult> DispatchAsync<TResult>(IQuery<TResult> query);
    }
}
