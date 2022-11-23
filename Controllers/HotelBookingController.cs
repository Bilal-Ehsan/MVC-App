using Microsoft.AspNetCore.Mvc;

using App.Models;

namespace App.Controllers
{
    public class HotelBookingController : Controller
    {
        public IActionResult HotelBookingDetails()
        {
            var hotel = new HotelBookingViewModel 
            { 
                Id = 1,
                GuestName = "Soldier Boy",
                DateStart = new DateTime(2022, 07, 09), 
                DateEnd = new DateTime(2022, 07, 14)
            };

            return View(hotel);
        }
    }
}
