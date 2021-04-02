namespace Subbotnik.Repository
{
    public interface ISubbotnikRepository
    {
        IBastardsRepo Bastards { get; }

        IMeetingsRepo Meetings { get; }

        IMoviesRepo Movies { get; }

        IRecommendationsRepo Recommendations { get; }
    }
}
