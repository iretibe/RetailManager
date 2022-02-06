using RetailManager.UI.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetailManager.UI.DAL.Api
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}