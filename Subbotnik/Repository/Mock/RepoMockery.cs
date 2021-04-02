namespace Subbotnik.Repository.Mock
{
    internal class RepoMockery : ISubbotnikRepository
    {
        public IBastardsRepo Bastards { get; }

        public IMeetingsRepo Meetings { get; }

        public IMoviesRepo Movies { get; }

        public IRecommendationsRepo Recommendations { get; }

        public RepoMockery()
        {
            // NOTE: the order of instantivation is crucial!
            //  More complex relations require to have all dictionaries populated.

            Bastards = new BastardsRepoMock();
            var bastList = Bastards.Get();

            Meetings = new MeetingsRepoMock(bastList);
            var meetsList = Meetings.Get();

            Movies = new MoviesRepoMock();
            var moviList = Movies.Get();

            Recommendations = new RecommendationsRepoMock(bastList, meetsList, moviList);
            var recoList = Recommendations.Get();
        }
    }
}
