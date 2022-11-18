using System.ComponentModel.DataAnnotations;
namespace BookingApp.API.Data.Entities
{
  public  class Payment
    {
        [Key]
        public Guid Payment_id { get; set; }
        public string Payment_type { get; set; }
        [StringLength(255)]
        public string name { get; set; }

        public Payment_Detail paymentDetail { get; set; }

    }
}