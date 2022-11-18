using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.BookingApp.API.Data.Entities
{
    public class BookingDetail
    {
        [Key]
        public Guid BookingDetailId { get; set; }
        
        public float RoomQuantity { get; set; }
        public DateTime Date { get; set; }
        public float Price { get; set; }
        
        public Guid roomTypeId { get; set; }
        [ForeignKey("roomTypeId")]
        public RoomType roomType { get; set; }

        public Guid BookingId { get; set; }
        [ForeignKey("BookingId")]
        public Booking booking { get; set; }
    }
}