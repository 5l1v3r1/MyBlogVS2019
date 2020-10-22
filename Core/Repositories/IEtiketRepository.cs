using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IEtiketRepository : IRepository<Etiket>
    {
        Task<IEnumerable<Blog>> GetAllWithBlogsByIdAsync(int blogId);
    }
}
