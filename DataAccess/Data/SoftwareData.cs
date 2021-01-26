using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SoftwareData : ISoftwareData
    {
        private readonly ISQL _db;

        public SoftwareData(ISQL db)
        {
            _db = db;
        }

        public Task<List<SoftwareModel>> GetSoftware()
        {
            string sql = "select * from Software";
            return _db.LoadData<SoftwareModel, dynamic>(sql, new { });
        }

        public Task InsertSoftware(SoftwareModel software)
        {
            string sql = @"insert into Software (ID, Manufacturer, SoftwareTitle, AssignedTo, PurchaseOrder, LicenseType, PurchaseDate, Supported, SupportExp, TotalKeys, UsedKeys, LicenseKey, Added) 
                        values (@ID, @Manufacturer, @SoftwareTitle, @AssignedTo, @PurchaseOrder, @LicenseType, @PurchaseDate, @Supported, @SupportExp, @TotalKeys, @UsedKeys, @LicenseKey, @Added)";
            return _db.SaveData(sql, software);
        }
    }
}
