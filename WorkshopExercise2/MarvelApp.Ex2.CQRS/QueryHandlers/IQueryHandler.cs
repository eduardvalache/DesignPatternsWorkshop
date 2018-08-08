using MarvelApp.Ex2.CQRS.Models.Query;

namespace MarvelApp.Ex2.CQRS.QueryHandlers
{
    public interface IQueryHandler<TQuery, TQueryResult> where TQuery : IQuery
        where TQueryResult : IQueryResult
    {
        TQueryResult Execute(TQuery query);
    }
}