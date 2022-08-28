using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using voleyballapp.entity;

namespace voleyballapp.data.Abstract
{
    public interface ITeamRepository : IRepository<Team>
    {
        Team GetTeamWithPlayers(int id);
        Fixture GetFixtureWithTeamId(int teamId);

        List<Team> GetTeamsFromFixture(Fixture fixture);
       
    }
}