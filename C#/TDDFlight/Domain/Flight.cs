using System.Security.Cryptography.X509Certificates;

namespace Domain
{
    public class Flight
    {
        List<Booking> bookingList = new();
        public IEnumerable<Booking> BookingList => bookingList;

        

        public int RemainingNumberOfSeats { get;  set; }
        public Flight(int seatCapacity) 
        { 
             RemainingNumberOfSeats = seatCapacity;
        }

        public object? Book(string passengerEmail, int numberOfSeats)
        {
            if (numberOfSeats > RemainingNumberOfSeats)
            {
                return new OverbookingError();
            }
            RemainingNumberOfSeats -= numberOfSeats;
            bookingList.Add(new Booking(passengerEmail, numberOfSeats));
            return null;
        }

        public object? CancelBooking(string passengerEmail, int numberOfSeats)
        {
            if(!bookingList.Any(booking => booking.Email == passengerEmail))
                return new BookinfNotFoundError();
            RemainingNumberOfSeats += numberOfSeats;
            return new BookinfNotFoundError();
           
        }
    }
}
