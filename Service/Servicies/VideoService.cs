using Core.Models;
using Core.Services;
using Core.UnitOfWorks;
using Data.Repositories;

namespace Service.Services
{
    public class VideoService : Service<Video>, IVideoService
    {
        public new readonly IUnitOfWork _unitOfWork;
        private readonly Repository<Video> _repository;
        public VideoService(IUnitOfWork unitOfWork, Repository<Video> repository) : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
