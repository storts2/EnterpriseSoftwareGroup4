// Made By Nabeel

using Group4API.Models;

namespace Group4API.Repositories
{
    public interface IWarehouseRepo
    {
        IEnumerable<Warehouse> ShowShelves();

        Warehouse GetShelfByID(int Id);

        IEnumerable<Warehouse> GetEmptyShelves();

        Warehouse UpdateShelf(Warehouse shelf);

        void ReserveShelf(Warehouse shelf);
    }
}
