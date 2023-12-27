using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje1;
using WebProje1.Models;

namespace AirplaneSeatReservation.Controllers
{
    public class UserController : Controller
    {
        private readonly DatabaseContext flightCS;

        public UserController(DatabaseContext flightCS)
        {
            this.flightCS = flightCS;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> FlightList()
        {
            var flights = await flightCS.Flights.ToListAsync();
            return View(flights);
        }

        [HttpGet]
        public IActionResult Reservation()
        {
            var flights = flightCS.Flights.ToList();
            ViewBag.Flights = new SelectList(flights, "FlightID", "FlightID");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Reservation(int flightID, string passengerName, string seatNumber)
        {
            // Rezervasyon işlemleri burada yapılır
            // flightID, passengerName, seatNumber gibi bilgileri kullanabilirsiniz

            ViewBag.correct = "Rezervasyon başarıyla yapıldı!";
            return View("Reservation");
        }

        // Diğer kullanıcı işlemleri için eylemler ekleyebilirsiniz
    }
}
