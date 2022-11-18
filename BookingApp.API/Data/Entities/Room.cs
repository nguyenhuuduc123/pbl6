using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.BookingApp.API.Data.Entities;

namespace BookingApp.API.Data.Entities
{
    public class Room
    {
        [Key]
        public Guid RoomId { get; set; }
        public int Number { get; set; }
        public Guid RoomTypeId { get; set; }
        [ForeignKey("RoomTypeId")]
        public virtual RoomType RoomType { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        public int MaxGuest { get; set; }
        public ICollection<RoomImage> RoomImages { get; set; }
        
       
    }
}