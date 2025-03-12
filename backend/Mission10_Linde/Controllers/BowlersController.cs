using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10_Linde.Data;

namespace Mission10_Linde.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private readonly IBowlerRepository _bowlerRepository;

        public BowlersController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }
        [HttpGet(Name = "GetBowlers")]
        public IEnumerable<object> Get()
        {
            var bowlerList = _bowlerRepository.Bowlers
                .Include(b => b.Team) // Load related Team data
                .Where(b => b.Team != null && (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
                .Select(b => new
                {
                    b.BowlerId,
                    b.BowlerFirstName,
                    b.BowlerLastName,
                    b.BowlerMiddleInit,
                    b.BowlerAddress,
                    b.BowlerCity,
                    b.BowlerState,
                    b.BowlerZip,
                    b.BowlerPhoneNumber,
                    b.TeamId,
                    TeamName = b.Team != null ? b.Team.TeamName : "No Team" // Handle null cases
                })
                .ToList();

            return bowlerList;
        }

    }
}
