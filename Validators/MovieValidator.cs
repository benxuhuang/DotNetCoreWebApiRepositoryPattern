using DotNetCoreWebApiRepositoryPattern.Models;
using FluentValidation;

namespace MyMusic.Api.Validations
{
    public class MovieValidator : AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(m => m.Title)
                .NotEmpty()
                .MaximumLength(60)
                .MinimumLength(3);
        }
    }
}