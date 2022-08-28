using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using voleyballapp.entity;

namespace voleyball.business.Abstract
{
    public interface ITeamService
    {
        Task<List<Team>> GetAllTeams();
        void AddTeam(Team t);
        Task<Team> GetById(int id);

        Team GetTeamWithPlayers(int id);
        Fixture GetFixtureWithTeamId(int teamId);
        List<Team> GetTeamsFromFixture(Fixture fixture);
    }
}