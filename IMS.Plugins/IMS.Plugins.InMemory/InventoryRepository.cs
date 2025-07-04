using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {

        public Task AddInventoryAsync(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Inventory?> GetInventoryByIdAsync(int inventoryId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateInventoryAsync(Inventory inventory)
        {
            throw new NotImplementedException();
        }
    }
}
