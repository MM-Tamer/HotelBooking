
using HotelBooking.Interfaces;
using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : Controller
    {
        private readonly IRoomRepository _roomRepository;
        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Room>))]
        [ProducesResponseType(404)]
        public IActionResult GetRooms(int lowerBound, int upperBound)
        {
            if (!(ModelState.IsValid))
            {
                return BadRequest(ModelState);
            }
            if(lowerBound > upperBound)
            {
                return BadRequest();
            }
            var rooms = _roomRepository.GetRoomsByPrice(lowerBound, upperBound);
            return Ok(rooms);
        }
    }
}
