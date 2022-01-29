using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joylet.API.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task Add<T>(T entity) where T : class;
        Task AddRange<T>(IEnumerable<T> entity) where T : class;

        Task<bool> SaveChangesAsync();
    }
}
