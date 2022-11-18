using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Data.Entities;

namespace BookingApp.BookingApp.API.Data
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int RoomAmount { get; set; }
        public bool Canceled { get; set; }
        public int CouponId { get; set; }
        public BookingDetail bookingDetail { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer customer { get; set; }
        public Guid Coupon_Id { get; set; }
        [ForeignKey("Coupon_Id")]
        public Coupon coupon { get; set; }
    }
}