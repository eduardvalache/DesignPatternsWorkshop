namespace MarvelApp.Ex2.Domain.SharedKernel
{
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }

        public string Alias { get; protected set; }
    }
}