using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Booking
    {
        public string Email { get; }
        public int NumberOfSeats { get; }
        public Booking(string passengerEmail, int numberOfSeats)
        {
            Email = passengerEmail;
            NumberOfSeats = numberOfSeats;
        }
    }
}
