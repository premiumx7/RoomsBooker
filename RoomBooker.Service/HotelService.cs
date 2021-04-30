using RoomBooker.Domain;
using RoomBooker.Domain.Repository;
using System.Collections.Generic;

namespace RoomBooker.Service
{
    public class HotelService : IHotelService
    {
        private readonly Hotel _hotel;
        public HotelService(IReservationRepository reservationRepository, IRoomRepository roomRepository)
        {
            _hotel = new Hotel(roomRepository, reservationRepository);
        }
        public void Add(Reservation reservation) => _hotel.AddReservation(reservation);
        public IEnumerable<Reservation> Get() => _hotel.Reservations; 
        public void RemoveReservation(int reservationId) => _hotel.RemoveReservation(reservationId);
    }
}
