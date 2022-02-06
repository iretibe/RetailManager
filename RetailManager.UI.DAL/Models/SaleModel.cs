using System.Collections.Generic;

namespace RetailManager.UI.DAL.Models
{
    public class SaleModel
    {
        public List<SaleDetailModel> SaleDetails { get; set; } = new List<SaleDetailModel>();
    }
}
