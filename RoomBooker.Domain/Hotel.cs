using RoomBooker.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RoomBooker.Domain
{
    public class Hotel
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IReservationRepository _reservationRepository;
        public Hotel(IRoomRepository roomRepository, IReservationRepository reservationRepository)
        {
            if (roomRepository == null || reservationRepository == null)
                throw new ArgumentException();

            _roomRepository = roomRepository;
            _reservationRepository = reservationRepository;
        }


        public int? TryGetFreeRoomId(Reservation reservation)
        {
            return AvailableRooms.FirstOrDefault(room => room.NumberOfBeedroms == reservation.NumberOfBeedroms)?.Id;
        }

        public int AddReservation(Reservation reservation)
        {
            var roomId = TryGetFreeRoomId(reservation);
            if (!roomId.HasValue)
            {
                throw new Exception("Not Available rooms");
            }

            reservation.RoomId = roomId.Value;
            _reservationRepository.Add(reservation);
            return roomId.Value;
        }



        public IEnumerable<Room> GetAvailableRooms()
        {
            var busy = Reservations.Select(x => x.Id).ToList();
            var rooms = Rooms.Where(x => !Reservations.Any(r => r.RoomId == x.Id)).ToList();

            return rooms;
        }

        public IEnumerable<Room> Rooms => _roomRepository.Get();
        public IEnumerable<Reservation> Reservations => _reservationRepository.Get();
        public IEnumerable<Room> AvailableRooms => GetAvailableRooms();
        public void RemoveReservation(int reservationId) => _reservationRepository.Remove(reservationId);
    }
}
