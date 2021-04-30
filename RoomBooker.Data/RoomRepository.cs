using RoomBooker.Domain;
using RoomBooker.Domain.Repository;
using System.Collections.Generic;

namespace RoomBooker.Data
{
    public class RoomRepository : IRoomRepository
    {
        public IEnumerable<Room> Get()
        => new List<Room>
        {
            new Room(1, 1),
            new Room(2, 1),
            new Room(3, 1),
            new Room(4, 1),

            new Room(5, 2),
            new Room(6, 2),
            new Room(7, 2),

            new Room(8, 3),
            new Room(9, 3),
            new Room(10, 3),
        };
    }
}
