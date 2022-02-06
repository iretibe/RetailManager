using RetailManager.DAL.DataAccess;
using RetailManager.DAL.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace RetailManager.Data.Controllers
{
    [Authorize]
    public class InventoryController : ApiController
    {
        [Authorize(Roles = "Admin,Manager")] // OR
        public List<InventoryModel> Get()
        {
            InventoryData data = new InventoryData();
            return data.GetInventory();
        }

        //[Authorize(Roles = "WarehouseWorker")] AND
        [Authorize(Roles = "Admin")]
        public void Post(InventoryModel item)
        {
            InventoryData data = new InventoryData();
            data.SaveInventoryRecord(item);
        }
    }
}