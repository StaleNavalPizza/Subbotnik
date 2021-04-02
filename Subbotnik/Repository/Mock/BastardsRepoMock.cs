using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

using Subbotnik.Model;

namespace Subbotnik.Repository.Mock
{
    internal class BastardsRepoMock : IBastardsRepo
    {
        private readonly ConcurrentBag<Bastard> _bastards;

        public BastardsRepoMock()
        {
            _bastards = new ConcurrentBag<Bastard>
            {
                new Bastard
                {
                    Id = 1,
                    Name = "Den",
                },
                new Bastard
                {
                    Id = 2,
                    Name = "Wowa",
                },
                new Bastard
                {
                    Id = 3,
                    Name = "Pablo",
                },
                new Bastard
                {
                    Id = 4,
                    Name = "SanSan",
                },
            };
        }

        public IEnumerable<Bastard> Get()
        {
            var safeList = _bastards.Select(bsd => bsd.Clone()).ToList();
            return safeList;
        }

        public Bastard Get(int key)
        {
            //IQueryable<Bastard> men;
            //men.FirstOrDefault ...

            // TODO: make the proper, effective, async search-by-key, using the IQueryable
            var man = _bastards.FirstOrDefault(bsd => bsd.Id == key);
            return man?.Clone();
        }
    }
}
