using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebProje1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebProje1;

namespace AirplaneSeatReservation.Controllers
{
    public class UserController : Controller
    {
        private readonly DatabaseContext flightCS;

        public UserController(DatabaseContext flightCS)
        {
            this.flightCS = flightCS;
        }

        [HttpGet]
        public IActionResult ViewFlights()
        {
            var flights = flightCS.Flights.Include(f => f.Aircraft).Include(f => f.Itinerary).ToList();
            return View(flights);
        }

        [HttpGet]
        public IActionResult Reservation()
        {
            var flights = flightCS.Flights.Include(f => f.Aircraft).Include(f => f.Itinerary).ToList();
            ViewBag.Flights = new SelectList(flights, "FlightID", "FlightDetails");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Reservation(string seatNumber, string departureAirport, string arrivalAirport, string departureTime, string departureDate)
        {
            // Rezervasyon işlemleri
            ViewBag.correct = "Rezervasyon başarıyla yapıldı!";
            return View("Reservation");
        }
    }
}
