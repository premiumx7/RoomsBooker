using System.Collections.Generic;

namespace RoomBooker.Domain.Repository
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> Get();
        void Add(Reservation reservation);
        void Remove(int reservationId);
    }
}
