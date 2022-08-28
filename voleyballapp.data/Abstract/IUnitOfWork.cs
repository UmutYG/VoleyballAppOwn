using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voleyballapp.data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IPlayerRepository Players {get;}
        ITeamRepository Teams {get;}

        void Save();

        Task<int> SaveAsync();
    }
}