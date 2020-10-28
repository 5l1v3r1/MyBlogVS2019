using Core.Models;
using Core.Services;
using Core.UnitOfWorks;
using Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Services
{
    public class BlogService : Service<Blog>, IBlogService
    {
        public new readonly IUnitOfWork _unitOfWork;
        private readonly Repository<Blog> _repository;
        public BlogService(IUnitOfWork unitOfWork, Repository<Blog> repository) : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        async Task<IEnumerable<Etiket>> IBlogService.GetWithEtiketsByIdAsync(int blogId)
        {
            return await _unitOfWork.Etikets.Where(x => x.BlogId == blogId);
        }

        async Task<IEnumerable<Image>> IBlogService.GetWithImagesByIdAsync(int blogId)
        {
            return await _unitOfWork.Images.Where(x => x.BlogId == blogId);
        }

        async Task<IEnumerable<Video>> IBlogService.GetWithVideosByIdAsync(int blogId)
        {
            return await _unitOfWork.Videos.Where(x => x.BlogId == blogId);
        }

        async Task<IEnumerable<Yorum>> IBlogService.GetWithYorumsByIdAsync(int blogId)
        {
            return await _unitOfWork.Yorums.Where(x => x.BlogId == blogId);
        }
    }
}
