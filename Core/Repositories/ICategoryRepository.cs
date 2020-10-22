using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<IEnumerable<Blog>> GetWithBlogsByIdAsync(int categoryId);
        Task<IEnumerable<Category>> GetWithCategoriesByIdAsync(int ustCcategoryId);
    }
}
