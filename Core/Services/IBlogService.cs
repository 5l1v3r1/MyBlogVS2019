using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IBlogService : IService<Blog>
    {
        Task<IEnumerable<Yorum>> GetWithYorumsByIdAsync(int blogId);
        Task<IEnumerable<Etiket>> GetWithEtiketsByIdAsync(int blogId);
        Task<IEnumerable<Image>> GetWithImagesByIdAsync(int blogId);
        Task<IEnumerable<Video>> GetWithVideosByIdAsync(int blogId);
    }
}
