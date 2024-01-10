using HotelBooking.Data;
using System.Diagnostics.Metrics;
using HotelBooking.Models;


namespace HotelBooking
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if(!dataContext.Rooms.Any())
            {
                
                var rooms = new List<Room>()
                {
                    new Room()
                        {
                            Description = "Double Room Sea View",
                            Price = 200,
                            Hotel = new Hotel()
                            {
                                Name = "Sheraton Hotel"
                            }
                        },
                    new Room()
                        {
                            Description = "Single Room Sea View",
                            Price = 150,
                            Hotel = new Hotel()
                            {
                                Name = "Sheraton Hotel"
                            }
                        },
                    new Room()
                        {
                            Description = "Double Room City View",
                            Price = 170,
                            Hotel = new Hotel()
                            {
                                Name = "Sheraton Hotel"
                            }
                        },
                    new Room()
                        {
                            Description = "Single Room City View",
                            Price = 200,
                            Hotel = new Hotel()
                            {
                                Name = "Sheraton Hotel"
                            }
                        },
                    new Room()
                        {
                            Description = "Double Room Garden View",
                            Price = 100,
                            Hotel = new Hotel()
                            {
                                Name = "Helnan Hotel"
                            }
                        },
                        new Room()
                        {
                            Description = "Single Room Garden View",
                            Price = 90,
                            Hotel = new Hotel()
                            {
                                Name = "Helnan Hotel"
                            }
                        },
                        new Room()
                        {
                            Description = "Double Room Pool View",
                            Price = 120,
                            Hotel = new Hotel()
                            {
                                Name = "Helnan Hotel"
                            }
                        },
                        new Room()
                        {
                            Description = "Single Room Pool View",
                            Price = 110,
                            Hotel = new Hotel()
                            {
                                Name = "Helnan Hotel"
                            }
                        },
                        new Room()
                        {
                            Description = "Double Room Standard",
                            Price = 80,
                            Hotel = new Hotel()
                            {
                                Name = "Tolip Hotel"
                            }
                        },
                        new Room()
                        {
                            Description = "Single Room Standard",
                            Price = 70,
                            Hotel = new Hotel()
                            {
                                Name = "Tolip Hotel"
                            }
                        },
                        new Room()
                        {
                            Description = "Double Room Deluxe",
                            Price = 100,
                            Hotel = new Hotel()
                            {
                                Name = "Tolip Hotel"
                            }
                        },
                        new Room()
                        {
                            Description = "Double Room Deluxe",
                            Price = 95,
                            Hotel = new Hotel()
                            {
                                Name = "Tolip Hotel"
                            }
                        },




                };
                dataContext.Rooms.AddRange(rooms);
                dataContext.SaveChanges();
            }
        }
    }
}


