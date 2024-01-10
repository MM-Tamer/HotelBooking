using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using HotelBooking.Models;
using Pomelo.EntityFrameworkCore.MySql;
using System.Security.Policy;

namespace HotelBooking.Data
{
    public class DataContext : DbContext
    {


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot config = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
            }  

                optionsBuilder.UseMySQL("server=localhost;database=hotelbooking;user=root;password=qwerty");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            

            

        }
    }
}
