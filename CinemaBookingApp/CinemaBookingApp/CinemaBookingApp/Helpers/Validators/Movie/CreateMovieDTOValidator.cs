using CinemaBookingApp.Helpers.Validators.MovieActor;
using FluentValidation;
using static CinemaBookingApp.Models.DTOs.Movie;


namespace CinemaBookingApp.Helpers.Validators.Movie
{
    public class CreateMovieDTOValidator : AbstractValidator<CreateMovieDTO>
    {
        public CreateMovieDTOValidator() { 
        
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");

            RuleFor(x => x.Director).NotEmpty().WithMessage("Director is required");

            RuleFor(x => x.Company).NotEmpty().WithMessage("Company is required");

            RuleFor(x => x.Duration).NotEmpty().WithMessage("Duration is required")
                .LessThanOrEqualTo(0).WithMessage("Duration is a positive number");

            RuleFor(x => x.ReleaseDate).NotEmpty().WithMessage("ReleaseDate is required")
                .LessThan(DateTime.Now).WithMessage("Invalid Date");

            RuleFor(x => x.PosterURL).NotEmpty().WithMessage("Poster is required");

            RuleFor(x => x.TrailerURL).NotEmpty().WithMessage("Trailer is required");

            RuleFor(x => x.Language).NotEmpty().WithMessage("Language is required");

            RuleForEach(x => x.GenreIDs).NotEmpty().WithMessage("Genre ID is required")
                                        .Must(id => id > 0).WithMessage("Genre ID must be a positive number");

            RuleForEach(x => x.CreateMovieActorDTOs)
                .SetValidator(new CreateMovieActorDTOValidator());
        }
    }
}
