using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess
{
    public class NetworkData : INetworkData
    {
        private readonly ISQL _db;

        public NetworkData(ISQL db)
        {
            _db = db;
        }

        public Task<List<NetworkModel>> GetNetwork()
        {
            string sql = "select * from Network";
            return _db.LoadData<NetworkModel, dynamic>(sql, new { });
        }

        public Task InsertNetwork(NetworkModel network)
        {
            string sql = @"insert into Network (ID, CCSD, Domain, CKT_Type, Source, SInt, SIP, Destination, DInt, DIP, CCO, Phone, DateAdded, AddedBy) 
                        values (@ID, @CCSD, @Domain, @CKT_Type, @Source, @SInt, @SIP, @Destination, @DInt, @DIP, @CCO, @Phone, @DateAdded, @AddedBy)";
            return _db.SaveData(sql, network);
        }
    }
}
