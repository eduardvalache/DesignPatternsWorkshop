namespace WorkshopExample._4._AggregateAndAggregateRoots
{
    public interface IRepository<TEntity> where TEntity : IAggregateRoot
    {
        void Create(TEntity aggregateRootEntity);

        void Read(string aggregateRootEntityId);

        void Update(TEntity aggregateRootEntity);

        void Delete(TEntity aggregateRootEntity);
    }
}