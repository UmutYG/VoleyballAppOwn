using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using voleyball.business.Abstract;
using voleyballapp.entity;
using voleyballapp.webui.Identity;
using voleyballapp.webui.Models;

namespace voleyballapp.webui.Controllers
{
    public class MatchController : Controller
    {   
        private ITeamService _teamService;
        private IPlayerService _playerService;
        private UserManager<User> _userManager;
        public MatchController(ITeamService teamService, IPlayerService playerService,UserManager<User> userManager)
        {
            this._teamService = teamService;
            this._playerService = playerService;
            this._userManager = userManager;
        }
        // public async Task<IActionResult> StartMatch()
        // {
        //     var user = await _userManager.FindByNameAsync(User.Identity.Name);
        //     if(user != null)
        //     {
        //         var teamEntity = _teamService.GetById(user.TeamId);
        //         var fixture = _teamService.GetFixtureWithTeamId(user.TeamId);
        //         var FixtureTeams = _teamService.GetTeamsFromFixture(fixture);

                
        //         var HostPlayers = _teamService.GetTeamWithPlayers(FixtureTeams[0].TeamId);
        //         var GuestPlayers = _teamService.GetTeamWithPlayers(FixtureTeams[1].TeamId);

        //         var winner = MatchMaker(HostPlayers, GuestPlayers);
        //         return View(new WinnerInfoModel()
        //         {
        //             WinnerTeam = winner
        //         });
            
        //     }else{
        //         return View();
        //     }

        // }

        public Team MatchMaker(Team team1, Team team2)
        {
            var Team1Players = team1.Players;
            var Team2Players = team2.Players;

            var HostLineup = new Dictionary<string, Player>();
            var GuestLineUp = new Dictionary<string, Player>();

            HostLineup.Add("Setter",Team1Players[0]);
            HostLineup.Add("Opposite",Team1Players[1]);
            HostLineup.Add("Libero",Team1Players[2]);
            HostLineup.Add("Outside Hitter",Team1Players[3]);
            HostLineup.Add("Outside Hitter2",Team1Players[4]);
            HostLineup.Add("Livero",Team1Players[5]);

            GuestLineUp.Add("Setter",Team2Players[0]);
            GuestLineUp.Add("Opposite",Team2Players[1]);
            GuestLineUp.Add("Libero",Team2Players[2]);
            GuestLineUp.Add("Outside Hitter",Team2Players[3]);
            GuestLineUp.Add("Outside Hitter2",Team2Players[4]);
            GuestLineUp.Add("Livero",Team2Players[5]);
            return team1;
        }
    }
}