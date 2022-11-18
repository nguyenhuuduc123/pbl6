namespace Model.Api {
    public class BookingModel
    {
        public Guid Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int RoomAmount { get; set; }
        public bool Canceled { get; set; }
        public int CouponId { get; set; }
        
       
    }
}