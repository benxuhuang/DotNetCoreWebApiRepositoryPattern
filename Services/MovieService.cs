
using DotNetCoreWebApiRepositoryPattern.Data;
using DotNetCoreWebApiRepositoryPattern.Models;

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
            await _unitOfWork.MovieRep.AddAsync(entity);
            return entity;
        }

        public async Task Delete(Movie entity)
        {
            _unitOfWork.MovieRep.Remove(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await _unitOfWork.MovieRep.GetAll();
        }

        public async Task<Movie> GetById(int id)
        {
            return await _unitOfWork.MovieRep.Get(id);
        }

        public async Task<Movie> Update(int id, Movie entity)
        {
            return await _unitOfWork.MovieRep.Update(id, entity);
        }
    }
}