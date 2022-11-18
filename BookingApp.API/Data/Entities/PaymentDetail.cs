using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookingApp.BookingApp.API.Data.Entities;

namespace BookingApp.API.Data.Entities{ 
   public class Payment_Detail {
    [Key]
    
    public Guid id { get; set; }
    public int Total_Price { get; set; }
    public bool status { get; set; }

    public DateTime Paydet_date { get; set; }


    public Guid Payment_id { get; set; }

    [ForeignKey("Payment_id")]
    public Payment payment { get; set; }

    public Guid bookingDetailId { get; set; }
    [ForeignKey("bookingDetailId")]
    public BookingDetail bookingDetail { get; set; }
}
}