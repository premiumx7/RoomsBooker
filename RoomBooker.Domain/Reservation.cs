using System;

namespace RoomBooker.Domain
{

    public class Reservation
    {
        private static int _reservationId = 0;
        public Reservation(int numberOfBeedroms, DateTime checkIn, DateTime checkOut, Client client)
        {
            Id = _reservationId++;
            CheckOut = checkOut;
            CheckIn = checkIn;
            Client = client;
            NumberOfBeedroms = numberOfBeedroms;

        }

        public int Id { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int NumberOfBeedroms { get; set; }
        public Client Client { get; set; }
    }
}
