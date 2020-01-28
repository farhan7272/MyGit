using LandonHotel.Data;
using LandonHotel.Repositories;

namespace LandonHotel.Services
{
    public class BookingService : IBookingService
    {
        private readonly IRoomsRepository _roomRepo;
        public BookingService(IRoomsRepository roomsRepository)
        {
            _roomRepo = roomsRepository;
        }

        public int CalculateBookingCost(int roomId, Booking booking)
        {
            return 0;
        }
    }
}
