using RaythosAerospace.Data.Base;
using RaythosAerospace.Models;

namespace RaythosAerospace.Data.Services
{
    public class InventoryService: EntityBaseRepository<Inventory>, IInventoryService
    {
        public InventoryService(AppDbContext context): base(context) { }
    }
}
