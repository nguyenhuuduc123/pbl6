using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.API.Data.Entities;
using BookingApp.BookingApp.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookingApp.BookingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomType { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<BookingDetail> BookingsDetails { get; set; }

        public DbSet<Coupon> Coupons { get; set; } 

         public DbSet<Customer> Customers { get; set; }

         public DbSet<History> History { get; set; }

         public DbSet<Hotel> Hotels { get; set; }

         public DbSet<Promotion> Promotions { get; set; }

         public DbSet<Promotion_Apply> Promotion_Apply { get; set;}


         public DbSet<RoomImage> RoomImages { get; set; }

        public DbSet<Payment> payment { get; set; }
        public DbSet<Payment_Detail> Payment_Detail { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Room>()
                .HasOne(u => u.RoomType)
                .WithMany()
                .HasForeignKey(u=>u.RoomTypeId);
            base.OnModelCreating(builder);

            
            
        }

    }
}