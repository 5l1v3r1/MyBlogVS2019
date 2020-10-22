using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IYorumRepository : IRepository<Yorum>
    {
        Task<IEnumerable<Yorum>> GetWithYorumsByIdAsync(int ustYorumId);
    }
}
