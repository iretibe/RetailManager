using RetailManager.DAL.DataAccess;
using RetailManager.DAL.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace RetailManager.Data.Controllers
{
    [Authorize(Roles = "Cashier")]
    public class ProductController : ApiController
    {
        public List<ProductModel> Get()
        {
            ProductData data = new ProductData();

            return data.GetProducts();
        }
    }
}
