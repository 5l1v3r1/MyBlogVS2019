using Core.Models;
using Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class YorumRepository : Repository<Yorum>, IYorumRepository
    {
        public YorumRepository(AppDbContext context) : base(context)
        {
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        async Task<IEnumerable<Yorum>> IYorumRepository.GetWithYorumsByIdAsync(int ustYorumId)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            return _context.Yorums.Where(x => x.UstId == ustYorumId);
        }

        //Task<Yorum> AddAsync(Yorum entity)
        //{
        //    _context.Yorums.AddAsync(entity);
        //}

        //public new async Task AddRangeAsync(IEnumerable<Yorum> entities)
        //{
        //    await _context.Yorums.AddRangeAsync(entities);
        //}

        //public new void Remove(Yorum entity)
        //{
        //    _context.Yorums.Remove(entity);
        //}

        //public new void RemoveRange(IEnumerable<Yorum> entities)
        //{
        //    _context.Yorums.RemoveRange(entities);
        //}

        //public new async Task<Yorum> SingleOrDefaultAsync(Expression<Func<Yorum, bool>> predicate)
        //{
        //    return await _context.Yorums.SingleOrDefaultAsync(predicate);
        //}

        //public new Yorum Update(Yorum entity)
        //{
        //    _context.Yorums.Update(entity);
        //    return entity;
        //}

        //public new async Task<IEnumerable<Yorum>> Where(Expression<Func<Yorum, bool>> predicate)
        //{
        //    return await _context.Yorums.Where(predicate).ToListAsync();
        //}

        //new async Task<IEnumerable<Yorum>> GetAllAsync()
        //{
        //    return await _context.Yorums.ToListAsync();
        //}

        //new ValueTask<Yorum> GetByIdAsync(int id)
        //{
        //    return _context.Yorums.FindAsync(id);
        //}

    }
}
