using System.ComponentModel.DataAnnotations.Schema;

namespace WebProje1.Models
{
	public class Flight
	{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FlightID { get; set; }
		public int ItineraryID { get; set; }
		public int AircraftID { get; set; }
     
    }
}
