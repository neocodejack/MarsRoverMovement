using MarsRover.Api.Repositories.Interfaces;
using MarsRover.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarsRover.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        public IMarsRoverRepository _repository = null;

        public DataController(IMarsRoverRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("addmoves")]
        public async Task<IActionResult> AddMoves(List<Moves> moves)
        {
            try
            {
                if (moves.Count <= 5)
                {
                    foreach (var item in moves)
                    {
                        await _repository.AddMovementValue(item.Left, item.Right, item.Top);
                    }

                    return Ok();
                }
                else
                {
                    return BadRequest("Should't exceed more than 5 items");
                }
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("totaldistance")]
        public async Task<IActionResult> TotalDistance()
        {
            return Ok(await _repository.TotalDistanceCovered());
        }
    }
}
