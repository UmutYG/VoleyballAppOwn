using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using voleyballapp.webui.Models;
using Microsoft.AspNetCore.Identity;
using voleyballapp.webui.Identity;
using voleyball.business.Abstract;
using voleyballapp.entity;

namespace voleyballapp.webui.Controllers
{
    public class MainController:Controller
    {
        private ITeamService _teamService;
        private IPlayerService _playerService;
        private UserManager<User> _userManager;
        public MainController(ITeamService teamService, IPlayerService playerService,UserManager<User> userManager)
        {
            this._teamService = teamService;
            this._playerService = playerService;
            this._userManager = userManager;
        }
        public IActionResult Matches()
        {
            return View();
        }

        public async Task<IActionResult> ChooseTeam()
        {
            var teams = await _teamService.GetAllTeams();
            return View(new TeamModel(){
                //Teams = await _teamService.GetAllTeams()
                Teams = teams
            });
        }

        [HttpPost]
        public async Task<IActionResult> ChooseTeam(string UserName, int TeamId)
        {
            var user = await _userManager.FindByNameAsync(UserName);
            var team = _teamService.GetById(TeamId);
            if(user != null)
            {
                user.TeamId = TeamId;
                await _userManager.UpdateAsync(user);
            }
            return Redirect("/home/index");
        }

        public async Task<IActionResult> Squad()
        {
            
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
           
            if(user != null)
            {
                var TeamId = user.TeamId;
                
                var userTeam = _teamService.GetTeamWithPlayers(TeamId);
                ViewBag.Team = await _teamService.GetById(TeamId);
                return View(new TeamPlayersModel(){
                TeamPlayers = userTeam.Players
            });
            }

            return View();
            
            
        }
    }
}