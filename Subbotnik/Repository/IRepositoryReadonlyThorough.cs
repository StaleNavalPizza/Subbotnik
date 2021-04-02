using System.Collections.Generic;

namespace Subbotnik.Repository
{
    public interface IRepositoryReadonlyThorough<TEntity>
    {
        IEnumerable<TEntity> Get();
    }
}
