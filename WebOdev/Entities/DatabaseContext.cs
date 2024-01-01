using Microsoft.EntityFrameworkCore;
using WebOdev.Entities;
using WebOdev.Models;

namespace WebOdev.Entities
{
    public class DatabaseContext : DbContext
    {

        private readonly IConfiguration _configuration;
        public DatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<User> Users { get; set; } //kullanıcı için
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Itinerary> Itineraries { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Passenger> Passengers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            }
        }

    }
}
