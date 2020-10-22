using Core.Models;
using Core.Repositories;

namespace Data.Repositories
{
    public class VideoRepository : Repository<Video>, IVideoRepository
    {
        public VideoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
