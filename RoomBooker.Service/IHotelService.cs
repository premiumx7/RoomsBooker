using RoomBooker.Domain;
using System.Collections.Generic;

namespace RoomBooker.Service
{
    public interface IHotelService
    {
        IEnumerable<Reservation> Get();
        void Add(Reservation reservation);
        void RemoveReservation(int reservationId);
    }
}
