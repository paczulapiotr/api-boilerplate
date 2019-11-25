using System.Threading.Tasks;

namespace Boilerplate.CQRS.Queries
{
    public interface IQueryHandler<TResult, TQuery> where TQuery : IQuery<TResult>
    {
        Task<TResult> HandleAsync(TQuery query);
    }
}
