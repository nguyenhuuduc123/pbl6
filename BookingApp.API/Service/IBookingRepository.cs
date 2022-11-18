using Booking.Api.Dtos;
using Model.Api;

namespace Service.api
{

    interface IBookingRepository {
        List<BookingDto> GetAllBooking();
        BookingDto GetOneBookingById(int id);
        BookingDto AddBooking(BookingModel booking_model);
        void Update(BookingDto bookingEditor);
        void Delete(int index);
    }
}