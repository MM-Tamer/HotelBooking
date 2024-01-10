namespace HotelBooking.Models
{
    public class Room
    {
        public int Id { get; set; } 
        public string Description { get; set; }
        public int Price { get; set; }
        public Hotel Hotel { get; set; }
        
    }
}
