using System;

namespace Hotelbookingsystem.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        public string CustomerName { get; set; }

        public string Email { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }
    }
}