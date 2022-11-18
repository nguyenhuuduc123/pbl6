using Booking.Api.Dtos;

using BookingApp.BookingApp.API.Data;
using Model.Api;

namespace Service.api {
    public class BookingRepository : IBookingRepository
    {   private readonly DataContext _context;
        public BookingRepository(DataContext context){
                _context = context;
        }
        public BookingDto AddBooking(BookingModel booking_model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }

        public List<BookingDto> GetAllBooking()
        {
            throw new NotImplementedException();
        }

        public BookingDto GetOneBookingById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(BookingDto bookingEditor)
        {
            throw new NotImplementedException();
        }
    }
}