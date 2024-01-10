namespace HotelBooking.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Room>   Room { get; set; }
        

    }
}
