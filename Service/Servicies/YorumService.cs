using Core.Models;
using Core.Services;
using Core.UnitOfWorks;
using Data.Repositories;

namespace Service.Services
{
    public class YorumService : Service<Yorum>, IYorumService
    {
        public new readonly IUnitOfWork _unitOfWork;
        private readonly Repository<Yorum> _repository;
        public YorumService(IUnitOfWork unitOfWork, Repository<Yorum> repository) : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }


    }
}
