using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<IEnumerable<Blog>> GetWithBlogsByIdAsync(int CategoryId);
        Task<IEnumerable<Category>> GetWithCategoriesByIdAsync(int ParentId);
    }
}
