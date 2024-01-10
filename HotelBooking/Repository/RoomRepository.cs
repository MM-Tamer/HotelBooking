using HotelBooking.Data;
using HotelBooking.Interfaces;
using HotelBooking.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly DataContext _context;

        public RoomRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Room> GetRoomsByPrice(int lowerBound, int upperBound)
        {
            /*
            var rooms = _context.Hotels.Include(r => r.Name);
            rooms.Where(r => (r.Price <= upperBound && r.Price >= lowerBound)).FirstOrDefault();

            return rooms;
            */
           return _context.Rooms.Where(r => (r.Price <= upperBound && r.Price >= lowerBound)).).ToList();
        }

        
    }
}
