using System.Threading.Tasks;
using Core.Repositories;
using Core.UnitOfWorks;
using Data.Repositories;

namespace Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private CategoryRepository _categoryRepository;
        private BlogRepository _blogRepository;
        private YorumRepository _yorumRepository;
        private EtiketRepository _etiketRepository;
        private VideoRepository _videoRepository;
        private ImageRepository _imageRepository;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        //public CategoryRepository CategoryRepository =>
        //        _categoryRepository ??= new CategoryRepository(_context);
        //public BlogRepository BlogRepository =>
        //        _blogRepository ??= new BlogRepository(_context);
        //public YorumRepository YorumRepository =>
        //        _yorumRepository ??= new YorumRepository(_context);
        //public EtiketRepository EtiketRepository =>
        //        _etiketRepository ??= new EtiketRepository(_context);
        //public VideoRepository VideoRepository =>
        //        _videoRepository ??= new VideoRepository(_context);
        //public ImageRepository ImageRepository =>
        //        _imageRepository ??= new ImageRepository(_context);

        ICategoryRepository IUnitOfWork.Categories => 
            _categoryRepository ??= new CategoryRepository(_context);

        IBlogRepository IUnitOfWork.Blogs =>
            _blogRepository ??= new BlogRepository(_context);

        IYorumRepository IUnitOfWork.Yorums =>
            _yorumRepository ??= new YorumRepository(_context);

        IEtiketRepository IUnitOfWork.Etikets =>
            _etiketRepository ??= new EtiketRepository(_context);

        IVideoRepository IUnitOfWork.Videos =>
            _videoRepository ??= new VideoRepository(_context);

        IImageRepository IUnitOfWork.Images =>
            _imageRepository ??= new ImageRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}