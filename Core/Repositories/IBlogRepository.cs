using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IBlogRepository : IRepository<Blog>
    {
        Task<IEnumerable<Yorum>> GetWithYorumsByIdAsync(int blogId);
        Task<IEnumerable<Etiket>> GetWithEtiketsByIdAsync(int blogId);
        Task<IEnumerable<Video>> GetWithVideosByIdAsync(int blogId);
        Task<IEnumerable<Image>> GetWithImagesByIdAsync(int blogId);

    }
}
