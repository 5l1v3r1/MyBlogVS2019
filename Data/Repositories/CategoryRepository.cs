using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext AppDbContext
        {
            get => _context;
        }
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Blog>> GetWithBlogsByIdAsync(int categoryId)
        {
            return (IEnumerable<Blog>) await AppDbContext.Categories
                .Include(x => x.Blogs)
                .SingleOrDefaultAsync(x => x.Id == categoryId);
        }
        async Task<IEnumerable<Category>> ICategoryRepository.GetWithCategoriesByIdAsync(int ParentId)
        {
            return await AppDbContext.Categories
                .Include(x => x.ParentId)
                .Where(x => x.ParentId == ParentId)
                .ToListAsync();
        }
    }
}
