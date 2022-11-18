using System;
using System.ComponentModel.DataAnnotations;
namespace BookingApp.API.Data.Entities{ 
  public  class Promotion {
    [Key]
    public Guid  Promotion_id { get; set; }
    public DateTime Date_start { get; set; }
    public DateTime Date_end{ get; set; }
    public int Discount_Rate { get; set; }
    public bool Is_Deleted { get; set; }
    public string Promotion_Name { get; set; }
    public Promotion_Apply promotion_Apply { get; set; }

}
}