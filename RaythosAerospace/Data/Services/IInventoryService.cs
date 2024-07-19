using RaythosAerospace.Data.Base;
using RaythosAerospace.Models;

namespace RaythosAerospace.Data.Services
{
    public interface IInventoryService : IEntityBaseRepository<Inventory>
    {
        Task<Inventory> GetInventoryByIdAsync(int id);
        Task UpdateInventoryAsync(Inventory inventory);
    }
}
