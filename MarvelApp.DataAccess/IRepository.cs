using MarvelApp.Domain.SharedKernel;

namespace MarvelApp.DataAccess
{
    public interface IRepository<TEntiy> where TEntiy : IAggregateRoot
    {
    }
}
