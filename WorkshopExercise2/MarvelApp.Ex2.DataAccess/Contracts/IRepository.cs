using MarvelApp.Ex2.Domain.SharedKernel;

namespace MarvelApp.Ex2.DataAccess.Contracts
{
    public interface IRepository<TEntiy> where TEntiy : BaseEntity
    {
        TEntiy GetById(int id);
        void Add(TEntiy entiy);
    }
}