using HotelBooking.Models;

namespace HotelBooking.Interfaces
{
    public interface IRoomRepository
    {
        ICollection<Room> GetRoomsByPrice(int lowerBound, int upperBound);
    }
}
