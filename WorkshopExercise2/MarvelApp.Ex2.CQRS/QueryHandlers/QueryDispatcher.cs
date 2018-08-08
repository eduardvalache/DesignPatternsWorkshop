using Autofac;
using MarvelApp.Ex2.CQRS.Models.Query;

namespace MarvelApp.Ex2.CQRS.QueryHandlers
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IComponentContext container;

        public QueryDispatcher(IComponentContext container)
        {
            this.container = container;
        }

        public TQueryResult Execute<TQuery, TQueryResult>(TQuery query) where TQuery : IQuery where TQueryResult : IQueryResult
        {
            var queryHandler = container.Resolve<IQueryHandler<TQuery, TQueryResult>>();

            return queryHandler.Execute(query);
        }
    }
}