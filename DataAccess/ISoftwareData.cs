using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ISoftwareData
    {
        Task<List<SoftwareModel>> GetSoftware();
        Task InsertSoftware(SoftwareModel software);
    }
}