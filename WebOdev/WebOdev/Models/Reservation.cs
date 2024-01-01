namespace WebOdev.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int FlightID { get; set; }
        public int SeatNumber { get; set; }
        public int PassengerID { get; set; }
        public string? DepartureAirport { get; set; }
        public string? ArrivalAirport { get; set; }
        public DateTime DepartureDate { get; set; }

    }
}
