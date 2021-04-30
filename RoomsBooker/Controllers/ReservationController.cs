using Microsoft.AspNetCore.Mvc;
using RoomBooker.Domain;
using RoomBooker.Service;
using System.Collections.Generic;

namespace RoomsBooker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public ReservationController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public IEnumerable<Reservation> Get()
        {
            return _hotelService.Get();
        }


        [HttpPost]
        public IActionResult Add(Reservation reservation)
        {
            _hotelService.Add(reservation);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int reservationId)
        {
            _hotelService.RemoveReservation(reservationId);

            return Ok();
        }
    }
}
