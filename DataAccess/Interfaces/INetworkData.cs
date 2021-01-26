using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface INetworkData
    {
        Task<List<NetworkModel>> GetNetwork();
        Task InsertNetwork(NetworkModel network);
    }
}