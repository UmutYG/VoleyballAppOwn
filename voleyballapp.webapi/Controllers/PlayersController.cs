using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using voleyball.business.Abstract;
using voleyballapp.entity;

namespace voleyballapp.webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : ControllerBase
    {
        private IPlayerService _playerService;
        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }
        [HttpGet]
        public async Task<IActionResult> GetPlayers()
        {
            var players = await _playerService.GetAllPlayers();

            return Ok(players);
        }
        [HttpGet("{id}")]
        public IActionResult GetPlayer(int id)
        {
            var p = _playerService.GetById(id);
            if(p == null)
            {
                return NotFound(); // 404
            }
            return Ok(p); // 200
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayer(Player p)
        {
            await _playerService.AddPlayerAsync(p);
            return CreatedAtAction(nameof(GetPlayer),new {id=p.PlayerId}, p);
        }

        // localhost:4000/api/players/2  bu id ile gönderilen id eşit mi kontrol ediyoruz.
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePlayer(int id, Player p)
        {
            if(id != p.PlayerId)
            {
                return BadRequest();
            }

            var player = await _playerService.GetById(id);
            if(player == null)
            {
                return NotFound();
            }

            await _playerService.UpdateAsync(player, p);

            return NoContent();


        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            var player = await _playerService.GetById(id);
            if(player == null)
            {
                return NotFound();
            }
            await _playerService.DeleteAsync(player);
            return NoContent();
        }
    }
}