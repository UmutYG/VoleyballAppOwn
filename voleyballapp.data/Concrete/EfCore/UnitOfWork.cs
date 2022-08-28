using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using voleyballapp.data.Abstract;

namespace voleyballapp.data.Concrete.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VoleyballContext _context;
        public UnitOfWork(VoleyballContext context)
        {
            _context = context;
        }
        private EfCorePlayerRepository _playerRepository;
        private EfCoreTeamRepository _teamRepository;
        public IPlayerRepository Players => _playerRepository = _playerRepository ?? new EfCorePlayerRepository(_context);

        public ITeamRepository Teams => _teamRepository = _teamRepository ?? new EfCoreTeamRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}