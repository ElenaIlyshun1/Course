using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDLL.Models;

namespace ServiceDLL.Interfaces
{
    public interface IClientService
    {
        List<ClientModel> GetClients();
        Task<List<ClientModel>> GetClientsAsync();
        int CreateClient(ClientModel client);
    }
}
