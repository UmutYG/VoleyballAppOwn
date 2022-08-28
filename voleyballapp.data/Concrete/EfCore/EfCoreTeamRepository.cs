using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using voleyballapp.data.Abstract;
using voleyballapp.entity;

namespace voleyballapp.data.Concrete.EfCore
{
    public class EfCoreTeamRepository : EfCoreGenericRepository<Team>, ITeamRepository
    {
        
        public EfCoreTeamRepository(VoleyballContext context) : base(context)
        {
            
        }
        public VoleyballContext VoleyballContext { get { return context as VoleyballContext; } }

        public Fixture GetFixtureWithTeamId(int teamId)
        {
            return VoleyballContext.Fixtures
                            .Where(i=>i.HostId == teamId || i.GuestId == teamId)
                            .FirstOrDefault();
        }

        public Team GetTeamWithPlayers(int id)
        {
            return VoleyballContext.Teams
                            .Where(i=>i.TeamId == id)
                            .Include(i=>i.Players)
                            .ThenInclude(i=>i.PlayerStats)
                            .Include(i=>i.Players)
                            .ThenInclude(i=>i.Nation)
                            .FirstOrDefault();
        }

        public List<Team> GetTeamsFromFixture(Fixture fixture)
        {
            return VoleyballContext.Teams
                            .Where(i=>i.TeamId == fixture.GuestId || i.TeamId == fixture.HostId)
                            .ToList();
            
        }

    }
}