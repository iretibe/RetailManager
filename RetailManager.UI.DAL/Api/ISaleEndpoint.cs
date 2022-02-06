using RetailManager.UI.DAL.Models;
using System.Threading.Tasks;

namespace RetailManager.UI.DAL.Api
{
    public interface ISaleEndpoint
    {
        Task PostSale(SaleModel sale);
    }
}