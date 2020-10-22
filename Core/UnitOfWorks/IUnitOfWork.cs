using Core.Repositories;
using System.Threading.Tasks;

namespace Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        ICategoryRepository Categories { get; }
        IBlogRepository Blogs { get; }
        IYorumRepository Yorums { get; }
        IEtiketRepository Etikets { get; }
        IVideoRepository Videos { get; }
        IImageRepository Images { get; }
        Task CommitAsync();
        void Commit();
    }
}
