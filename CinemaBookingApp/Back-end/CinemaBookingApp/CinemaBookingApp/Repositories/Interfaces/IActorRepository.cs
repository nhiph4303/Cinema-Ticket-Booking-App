using CinemaBookingApp.Models.Entities;

namespace CinemaBookingApp.Repositories.Interfaces
{
    public interface IActorRepository
    {
        Task AddAsync(Actor actor);
    }
}
