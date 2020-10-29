using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;
using Core.Services;
using Core.UnitOfWorks;
using Data.Repositories;

namespace Services.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public new readonly IUnitOfWork _unitOfWork;
        private readonly Repository<Category> _repository;
        public CategoryService(IUnitOfWork unitOfWork, Repository<Category> repository) : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        async Task<IEnumerable<Blog>> ICategoryService.GetWithBlogsByIdAsync(int CategoryId)
        {
            return await _unitOfWork.Categories.GetWithBlogsByIdAsync(CategoryId);
        }

        async Task<IEnumerable<Category>> ICategoryService.GetWithCategoriesByIdAsync(int ParentId)
        {
            return await _unitOfWork.Categories.GetWithCategoriesByIdAsync(ParentId);
        }
    }
}