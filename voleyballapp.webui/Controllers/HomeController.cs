using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using voleyball.business.Abstract;
using voleyballapp.entity;
using voleyballapp.webui.Identity;
using voleyballapp.webui.Models;

namespace voleyballapp.webui.Controllers
{
    public class HomeController : Controller
    {
        private ITeamService _teamService;
        private IPlayerService _playerService;
        private UserManager<User> _userManager;
        public HomeController(ITeamService teamService, IPlayerService playerService,UserManager<User> userManager)
        {
            this._teamService = teamService;
            this._playerService = playerService;
            this._userManager = userManager;
        }

        [Authorize]
        public async Task<IActionResult> Index(UserInfoModel model)
        {
            
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if(user != null)
            {
                var teamEntity = await _teamService.GetById(user.TeamId);
                var fixture = _teamService.GetFixtureWithTeamId(user.TeamId);
                var teams = await _teamService.GetAllTeams();
                model = new UserInfoModel()
            {
                TeamInfo = teamEntity,
                FixtureTeams = _teamService.GetTeamsFromFixture(fixture),
                
            };
            ViewBag.Teams = teams;
            }
            
            return View(model);
        }
    }
}