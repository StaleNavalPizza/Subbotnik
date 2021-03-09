using System.Collections.Generic;
using System.Linq;

using Subbotnik.Model;

namespace Subbotnik.Repository
{
    public static class Bastards
    {
        private static readonly List<Bastard> _bastards;

        static Bastards()
        {
            _bastards = new List<Bastard>
            {
                new Bastard
                {
                    Name = "Den",
                },
                new Bastard
                {
                    Name = "Wowa",
                },
                new Bastard
                {
                    Name = "Pablo",
                },
                new Bastard
                {
                    Name = "SanSan",
                },
            };
        }

        public static List<Bastard> GetAllMen()
        {
            var safeList = _bastards.Select(org => org.Clone()).ToList();
            return safeList;
        }
    }
}
