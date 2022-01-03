
using DotNetCoreWebApiRepositoryPattern.Data;
using DotNetCoreWebApiRepositoryPattern.Models;
using MyMusic.Api.Validations;

namespace DotNetCoreWebApiRepositoryPattern.Services
{
    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MovieService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Movie> Create(Movie entity)
        {
            var validator = new MovieValidator();
            var validationResult = await validator.ValidateAsync(entity);
            if (!validationResult.IsValid)
                throw new Exception(validationResult.Errors.ToString());

            await _unitOfWork.MovieRep.AddAsync(entity);

            return entity;
        }

        public async Task Delete(Movie entity)
        {
            await _unitOfWork.MovieRep.Remove(entity);
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await _unitOfWork.MovieRep.GetAllAsync();
        }

        public async Task<Movie> GetById(int id)
        {
            return await _unitOfWork.MovieRep.GetByIdAsync(id);
        }

        public async Task<Movie> Update(int id, Movie entity)
        {
            return await _unitOfWork.MovieRep.Update(id, entity);
        }
    }
}