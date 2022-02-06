using RetailManager.UI.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetailManager.UI.DAL.Api
{
    public interface IUserEndpoint
    {
        Task<List<UserModel>> GetAll();
    }
}