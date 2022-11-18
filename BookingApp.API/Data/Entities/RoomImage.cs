using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.API.Data.Entities;

namespace BookingApp.BookingApp.API.Data.Entities
{
    public class RoomImage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string DataUrl { get; set; }
        public Guid room_id { get; set; }
        [ForeignKey("room_id")]
        public Room Rooms { get; set; }
    }
}