using Packaging.Domain.Entities;
using Packaging.Domain.ValueObjects;

namespace Packaging.Domain.Repositories
{
    public interface IPackingListRepository
    {
        Task<PackingList> GetAsync(PackingListId id);
        Task AddAsync(PackingList entity);
        Task UpdateAsync(PackingList entity);
        Task DeleteAsync(PackingList entity);
    }
}