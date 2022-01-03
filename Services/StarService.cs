
using DotNetCoreWebApiRepositoryPattern.Data;
using DotNetCoreWebApiRepositoryPattern.Models;

namespace DotNetCoreWebApiRepositoryPattern.Services
{
    public class StarService : IStarService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StarService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Star> Create(Star entity)
        {
            await _unitOfWork.StarRep.AddAsync(entity);
            return entity;
        }

        public async Task Delete(Star entity)
        {
            _unitOfWork.StarRep.Remove(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Star>> GetAll()
        {
            return await _unitOfWork.StarRep.GetAllAsync();
        }

        public async Task<Star> GetById(int id)
        {
            return await _unitOfWork.StarRep.GetByIdAsync(id);
        }

        public async Task<Star> Update(int id, Star entity)
        {
            return await _unitOfWork.StarRep.Update(id, entity);
        }
    }
}