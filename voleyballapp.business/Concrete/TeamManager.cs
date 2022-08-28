using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using voleyballapp.data.Abstract;
using voleyballapp.entity;
using voleyball.business.Abstract;

namespace voleyball.business.Concrete
{
    public class TeamManager : ITeamService
    {
        private readonly IUnitOfWork _unitofwork;
        public TeamManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public void AddTeam(Team t)
        {
            _unitofwork.Teams.Create(t);
        }

        public async Task<List<Team>> GetAllTeams()
        {
            return await _unitofwork.Teams.GetAll();
        }

        public async Task<Team> GetById(int id)
        {
            return await _unitofwork.Teams.GetById(id);
        }

        public Fixture GetFixtureWithTeamId(int teamId)
        {
            return _unitofwork.Teams.GetFixtureWithTeamId(teamId);
        }

        public Team GetTeamWithPlayers(int id)
        {
            return _unitofwork.Teams.GetTeamWithPlayers(id);
        }

        public List<Team> GetTeamsFromFixture(Fixture fixture)
        {
            return _unitofwork.Teams.GetTeamsFromFixture(fixture);
        }

      
    }
    
    }
