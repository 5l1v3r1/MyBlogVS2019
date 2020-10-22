using Core.Models;
using Core.Services;
using Core.UnitOfWorks;
using Data.Repositories;

namespace Service.Services
{
    public class EtiketService : Service<Etiket>, IEtiketService
    {
        public new readonly IUnitOfWork _unitOfWork;
        private readonly Repository<Etiket> _repository;
        public EtiketService(IUnitOfWork unitOfWork, Repository<Etiket> repository) : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

    }
}
