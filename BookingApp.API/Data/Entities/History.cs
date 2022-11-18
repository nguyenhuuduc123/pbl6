using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.API.Data.Entities;

namespace BookingApp.BookingApp.API.Data.Entities
{
    public class History
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PaymentDetailId { get; set; }
        [ForeignKey("PaymentDetailId")]
        public Payment_Detail Payment_id { get; set; }
        public int BookingDetailId { get; set; }
    }
}