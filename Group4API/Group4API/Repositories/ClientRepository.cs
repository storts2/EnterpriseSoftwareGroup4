using Group4API.DataAccessLayer;
using Group4API.Models;

namespace Group4API.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly JobManagementDbContext _context;
        public ClientRepository(JobManagementDbContext context)
        {
            _context = context;
        }

        public Client AddClient(Client client)
        {
            if (client == null)
            {
                throw new ArgumentNullException("Client information is invalid.\n");
            }
            _context.Clients.Add(client);
            _context.SaveChanges();
            return client;
        }

        public void DeleteClientById(int id)
        {
            var client = GetClientById(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Client id is not found.\n");
            }
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _context.Clients;
        }

        public Client GetClientById(int id)
        {
            return _context.Clients.FirstOrDefault(c => c.ClientId == id);
        }

        public void UpdateClient(Client client)
        {
            var existingClient = GetClientById(client.ClientId);
            if (existingClient != null)
            {
                existingClient.Address = client.Address;
                existingClient.Email = client.Email;
                existingClient.FirstName = client.FirstName;
                existingClient.LastName = client.LastName;
                existingClient.PhoneNumber = client.PhoneNumber;
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Client id is not found.\n");
            }
        }
    }
}
