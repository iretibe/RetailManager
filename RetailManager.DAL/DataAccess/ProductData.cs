using RetailManager.DAL.Internal.DataAccess;
using RetailManager.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace RetailManager.DAL.DataAccess
{
    public class ProductData
    {
        public List<ProductModel> GetProducts()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ProductModel, dynamic>("dbo.spProductGetAll", new { }, "RetailManager.Data");

            return output;
        }

        public ProductModel GetProductById(int productId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ProductModel, dynamic>("dbo.spProductGetById", new { Id = productId }, "RetailManager.Data").FirstOrDefault();

            return output;
        }
    }
}
