using Microsoft.EntityFrameworkCore;
using RaythosAerospace.Data.Base;
using RaythosAerospace.Models;

namespace RaythosAerospace.Data.Services
{
    public class InventoryService: EntityBaseRepository<Inventory>, IInventoryService
    {
        private readonly AppDbContext _context;

        public InventoryService(AppDbContext context): base(context)
        {
            _context = context;
        }

        public async Task<Inventory> GetInventoryByIdAsync(int id)
        {
            var inventoryDetails = _context.Inventory
                .Include(i => i.Aircraft)
                .FirstOrDefaultAsync(n => n.Id == id);

            return await inventoryDetails;
        }

        public async Task UpdateInventoryAsync(Inventory inventory)
        {

            var newInventory = await _context.Inventory.FirstOrDefaultAsync(n => n.Id == inventory.Id);

            if (newInventory != null)
            {
                newInventory.Quantity = inventory.Quantity;
                newInventory.RestockDate = inventory.RestockDate;
                newInventory.AircraftId = inventory.AircraftId;
                newInventory.Aircraft = inventory.Aircraft;
                await _context.SaveChangesAsync();
            }

            //var existingAircraft = _context.Aircraft.Where(n => n.Id == inventory.Id).ToList();
            //_context.Aircraft.RemoveRange(existingAircraft);
            //await _context.SaveChangesAsync();

            //foreach (var aircraftId in inventory.AircraftId)
            //{

            //}
            await _context.SaveChangesAsync();
        }
    }
}
