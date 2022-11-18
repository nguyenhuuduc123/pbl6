namespace Booking.Api.Dtos {
    public class BookingDto
    {
        public Guid Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int RoomAmount { get; set; }
        public bool Canceled { get; set; } 

    }
}