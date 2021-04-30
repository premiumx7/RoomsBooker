using System.Collections.Generic;

namespace RoomBooker.Domain.Repository
{
    public interface IRoomRepository
    {
        IEnumerable<Room> Get();
    }
}
