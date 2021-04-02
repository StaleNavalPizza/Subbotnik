namespace Subbotnik.Repository
{
    public interface IRepositoryReadonly<TEntity>
    {
        TEntity Get(int key);
    }
}
