using RetailManager.DAL.Internal.DataAccess;
using RetailManager.DAL.Models;
using System.Collections.Generic;

namespace RetailManager.DAL.DataAccess
{
    public class InventoryData
    {
        public List<InventoryModel> GetInventory()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<InventoryModel, dynamic>("dbo.spInventory_GetAll", new { }, "RetailManager.Data");

            return output;
        }

        public void SaveInventoryRecord(InventoryModel item)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SaveData("dbo.spInventory_Insert", item, "RetailManager.Data");
        }
    }
}
