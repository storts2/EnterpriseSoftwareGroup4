using Group4API.Models;
// MADE BY JOHNY
namespace Group4API.Repositories
{
    public interface IClientRepository
    {
        public IEnumerable<Client> GetAllClients();
        public Client GetClientById(int id);
        public Client AddClient(Client client);
        public void DeleteClientById(int id);
        public void UpdateClient(Client client);
    }
}
