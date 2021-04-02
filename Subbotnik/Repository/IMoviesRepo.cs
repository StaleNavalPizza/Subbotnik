using System;

using Subbotnik.Model;

namespace Subbotnik.Repository
{
    public interface IMoviesRepo : IRepositoryReadonly<Movie>, IRepositoryReadonlyThorough<Movie>
    {

    }
}
