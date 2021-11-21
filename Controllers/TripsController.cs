using Microsoft.AspNetCore.Mvc;
using Trips.Data.Models;
using Trips.Data.Services;

namespace Trips.Controllers
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private readonly ITripService _service;

        public TripsController(ITripService service)
        {
            _service = service;
        }

        [HttpPost("AddTrip")]
        public IActionResult AddTrip([FromBody] Trip trip)
        {
            if (trip != null)
            {
                _service.AddTrip(trip);
            }

            return Ok();
        }
    }
}