using MarvelApp.Ex2.CQRS.Models.Query;

namespace MarvelApp.Ex2.CQRS.QueryHandlers
{
    public interface IQueryDispatcher
    {
        TQueryResult Execute<TQuery, TQueryResult>(TQuery query)
            where TQuery : IQuery
            where TQueryResult : IQueryResult;
    }
}