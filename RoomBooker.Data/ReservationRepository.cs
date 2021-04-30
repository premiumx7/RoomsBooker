using RoomBooker.Domain;
using RoomBooker.Domain.Repository;
using System.Collections.Generic;
using System.Linq;

namespace RoomBooker.Data
{
    public class ReservationRepository : IReservationRepository
    {
        private List<Reservation> _reservation;
        public ReservationRepository()
        {
            _reservation = new List<Reservation>();
        }
        public void Add(Reservation reservation)
        {
            _reservation.Add(reservation);
        }

        public IEnumerable<Reservation> Get()
        {
            return _reservation;
        }

        public void Remove(int reservationId)
        {
            var existingReservation = _reservation.FirstOrDefault(x => x.RoomId == reservationId);
            if(existingReservation != null)
            {
                _reservation.Remove(existingReservation);
            }
        }
    }
}
