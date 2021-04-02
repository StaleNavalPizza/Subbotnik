using System;
using System.Collections.Generic;
using System.Text;

using Subbotnik.Repository;
using Subbotnik.Repository.Mock;

namespace Subbotnik.Setup
{
    public static class RepositorySetup
    {
        public static ISubbotnikRepository Repo { get; private set; }

        public static void Init()
        {
            Repo = new RepoMockery();
        }
    }
}
