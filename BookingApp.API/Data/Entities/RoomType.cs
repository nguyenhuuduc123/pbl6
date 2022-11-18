using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.API.Data.Entities;

namespace BookingApp.BookingApp.API.Data.Entities
{
    public class RoomType
    {
        [Key]
        public Guid RoomTypeId { get; set; }
        public string Name { get; set; }
        public float Quantity { get; set; }
        public decimal BasePrice { get; set; }
        public bool IsDelete { get; set; }
        public string Description { get; set; }
        
        public float NumChildren { get; set; }
        public float NumAdult { get; set; }

        public Room Room { get; set; }
        

    }
}