using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(AppDbContext context) : base(context)
        {
        }

        async Task<IEnumerable<Etiket>> IBlogRepository.GetWithEtiketsByIdAsync(int blogId)
        {
            return await _context.Etikets.Where(x => x.BlogId == blogId).ToListAsync();
        }

        async Task<IEnumerable<Image>> IBlogRepository.GetWithImagesByIdAsync(int blogId)
        {
            return await _context.Images.Where(x => x.BlogId == blogId).ToListAsync();
        }

        async Task<IEnumerable<Video>> IBlogRepository.GetWithVideosByIdAsync(int blogId)
        {
            return await _context.Videos.Where(x => x.BlogId == blogId).ToListAsync();
        }

        async Task<IEnumerable<Yorum>> IBlogRepository.GetWithYorumsByIdAsync(int blogId)
        {
            return await _context.Yorums.Where(x => x.BlogId == blogId).ToListAsync();
        }
    }
}