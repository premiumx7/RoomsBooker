using System;

namespace RoomBooker.Domain
{
    public class Room
    {
        public Room(int id, int numberOfBeedroms)
        {
            Id = id;
            NumberOfBeedroms = numberOfBeedroms;
        }
        public int Id { get; set; }
        public int NumberOfBeedroms { get; set; }
    }
}
