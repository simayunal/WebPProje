namespace WebProje1.Models
{
	public class Itinerary
	{
		public int ItineraryID { get; set; }
		public string? DeparturCity { get; set; }
		public string? ArrivalCity { get; set; }
		public string? DepartureAirport { get; set; }
        public string? DepartureCity { get; set; }
        public string? ArrivalAirport { get; set; }
        public string? DepartureDate { get; set; }
        public string? DepartureTime { get; set; }
    }
}
