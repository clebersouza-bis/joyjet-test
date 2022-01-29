using Joylet.API.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joylet.API.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task Add<T>(T entity) where T : class
        {
           await _context.AddAsync(entity);
        }

        public async Task AddRange<T>(IEnumerable<T> entity) where T : class
        {
            await _context.AddRangeAsync(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await (_context.SaveChangesAsync()) > 0;
        }
    }
}
