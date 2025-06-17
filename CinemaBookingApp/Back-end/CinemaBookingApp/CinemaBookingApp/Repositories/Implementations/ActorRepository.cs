using CinemaBookingApp.Data;
using CinemaBookingApp.Models.Entities;
using CinemaBookingApp.Repositories.Interfaces;

namespace CinemaBookingApp.Repositories.Implementations
{
    public class ActorRepository : IActorRepository
    {
        private readonly AppDbContext _context;

        public ActorRepository(AppDbContext context) { 
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            _context.Actor.Add(actor);
            await _context.SaveChangesAsync();
        }

    }
}
