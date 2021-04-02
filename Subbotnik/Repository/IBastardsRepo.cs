using System;

using Subbotnik.Model;

namespace Subbotnik.Repository
{
    public interface IBastardsRepo : IRepositoryReadonly<Bastard>, IRepositoryReadonlyThorough<Bastard>
    {

    }
}
