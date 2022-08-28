using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using voleyballapp.data.Abstract;
using voleyballapp.entity;
using voleyball.business.Abstract;

namespace voleyball.business.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private readonly IUnitOfWork _unitofwork;
        public PlayerManager(IUnitOfWork unitofwork)
        {
            
            _unitofwork = unitofwork;
        }

        public void AddPlayer(Player p)
        {
            _unitofwork.Players.Create(p);
        }

        public async Task<Player> AddPlayerAsync(Player p)
        {
           await _unitofwork.Players.CreateAsync(p);
           await _unitofwork.SaveAsync(); // bunu unutma kayıtta önemli bişi getirmiyorsun
           return p;
        }

        public async Task DeleteAsync(Player p)
        {
            _unitofwork.Players.Delete(p);
            await _unitofwork.SaveAsync();
        }

        public async Task<List<Player>> GetAllPlayers()
        {
            return await _unitofwork.Players.GetAll();
        }

        public async Task<Player> GetById(int id)
        {
            return await _unitofwork.Players.GetById(id);
        }

        public List<Player> GetTeamPlayers(int teamId)
        {
            return _unitofwork.Players.GetTeamPlayers(teamId);
        }

        public async Task UpdateAsync(Player playerToUpdate, Player p)
        {
            playerToUpdate.Name = p.Name;
            playerToUpdate.Age = p.Age;
            playerToUpdate.NationId = p.NationId;
            //...
            await _unitofwork.SaveAsync();
        }
    }
}