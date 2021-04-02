using System;

using Subbotnik.Model;

namespace Subbotnik.Repository
{
    public interface IRecommendationsRepo : IRepositoryReadonly<Recommendation>, IRepositoryReadonlyThorough<Recommendation>
    {

    }
}
