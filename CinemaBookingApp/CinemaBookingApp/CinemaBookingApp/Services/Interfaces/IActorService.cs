using static CinemaBookingApp.Models.DTOs.Actor;

namespace CinemaBookingApp.Services.Interfaces
{
    public interface IActorService
    {
        Task<string> AddAsync(CreateActorDTO dto);
    }
}
