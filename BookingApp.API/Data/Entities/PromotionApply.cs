using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookingApp.BookingApp.API.Data.Entities;

namespace BookingApp.API.Data.Entities{ 
  public  class Promotion_Apply {
    [Key]
    public Guid  Promotion_Apply_Id { get; set; }
    public Guid  Promotion_id { get; set; }
    [ForeignKey("Promotion_id")]
    public Promotion promotion { get; set; }
    public Guid  room_type_id { get; set; }
    [ForeignKey("room_type_id")]
    public RoomType RoomType { get; set; }

}
}