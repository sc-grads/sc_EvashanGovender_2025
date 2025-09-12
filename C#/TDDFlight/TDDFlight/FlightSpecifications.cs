using FluentAssertions;
using Domain;


namespace TDDFlight
{
    public class FlightSpecifications
    {

        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(6, 3, 3)]
        [InlineData(10, 4, 6)]
        public void Booking_reduces_the_number_of_seats(int seatCapacity, int numberOfSeats, int remainingNumberOfSeats)
        {
            var flight = new Flight(seatCapacity);

            flight.Book("jannick@tutorialleu.com", numberOfSeats);

            flight.RemainingNumberOfSeats.Should().Be(remainingNumberOfSeats);
        }

        [Fact]
        public void Avoids_overbooking()
        {
            var flight = new Flight(3);
            var error = flight.Book("jannick@tutorialleu.com", 4);

            error.Should().BeOfType<OverbookingError>();
        }

        [Fact]
        public void Books_Flights_successfully()
        {
            var flight = new Flight(3);
            var error = flight.Book("jannick@tutorialleu.com", 4);

            error.Should().BeNull();
        }

        [Fact]
        public void Remebers_bookings()
        {
            var flight = new Flight(150);
            flight.Book("jannick@tutorialleu.com", 4);
            flight.BookingList.Should().ContainEquivalentOf(new Booking("jannick@tutorialleu.com", 4));

        }

        [Theory]
        [InlineData(3,1,1,3)]
        [InlineData(4, 2, 2, 4)]
        [InlineData(7, 5, 4, 6)]
        public void Cancel_bookings(int initialCapacity, int NumOfSeatsToBook, int NumofSeatsToCancel, int remainingNumOfSeats)
        {
            var flight = new Flight(initialCapacity);

            flight.Book("jannick@tutorialleu.com", NumOfSeatsToBook);
            flight.CancelBooking("jannick@tutorialleu.com", NumofSeatsToCancel);

            flight.RemainingNumberOfSeats.Should().Be(remainingNumOfSeats);
        }

        [Fact]
        public void Doesnt_Cancel_bookings_for_passengers_who_havent_booked()
        {
            var flight = new Flight(3);
            var error = flight.CancelBooking("a@b.com", 2);
            error.Should().BeOfType<OverbookingError>();
        }

        [Fact]
        public void Returns_null_when_cancelling_a_booking_successfully()
        {
            var flight = new Flight(3);
            flight.Book("jannick@tutorialleu.com", 1);
            var error = flight.CancelBooking("a@b.com", 1);
            error.Should().BeNull();
        }
    }
}