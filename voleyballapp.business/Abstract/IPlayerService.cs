using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using voleyballapp.entity;

namespace voleyball.business.Abstract
{
    public interface IPlayerService
    {
        Task<List<Player>> GetAllPlayers();

        void AddPlayer(Player p);
        Task<Player> AddPlayerAsync(Player p);

        List<Player> GetTeamPlayers(int teamId);

        Task<Player> GetById(int id);

        Task UpdateAsync(Player playerToUpdate, Player p);

        Task DeleteAsync(Player p);
    }

    
}