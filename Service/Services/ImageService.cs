using Core.Models;
using Core.Services;
using Core.UnitOfWorks;
using Data.Repositories;

namespace Services.Services
{
    public class ImageService : Service<Image>, IImageService
    {
        public new readonly IUnitOfWork _unitOfWork;
        private readonly Repository<Image> _repository;
        public ImageService(IUnitOfWork unitOfWork, Repository<Image> repository) : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
