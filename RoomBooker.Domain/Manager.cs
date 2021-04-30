using System.Collections.Generic;

namespace RoomBooker.Domain
{
    public class Manager
    {
        public IEnumerable<Reservation> Reservations { get; set; }
    }
}
