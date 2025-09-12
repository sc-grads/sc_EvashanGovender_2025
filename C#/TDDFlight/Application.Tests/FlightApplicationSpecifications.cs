using FluentAssertions;
using System.Collections.Generic;


namespace Application.Tests
{
    public class FlightApplicationSpecifications
    {
        [Fact]
        public void Books_flights()
        {
            var bookingService = new BookingService();
            bookingService.Book(new BookDto(Guid.NewGuid(),"a@b.com",2));
            bookingService.FindBookings().Should().ContainEquivalentOf(new BookingRm());
        }

    }

    public class BookingService
    {
        public void Book(BookDto bookDto)
        {
            // Booking logic here

        }

        public IEnumerable<BookingRm> FindBookings()
        {
            // Finding bookings logic here
            return new[]
            {
                new BookingRm("a random string",25)
            };
        }
    }

    public class BookDto
    {
        public BookDto(Guid flightId, string passegerEmail, int NumberOfSeats)
        {

        }
    }

    public class  BookingRm
    {
        public BookingRm(string passengerEmail, int NumberofSeats)
        {
        }

    }
}