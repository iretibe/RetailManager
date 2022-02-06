using RetailManager.DAL.Internal.DataAccess;
using RetailManager.DAL.Models;
using System.Collections.Generic;

namespace RetailManager.DAL.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id = Id };

            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "RetailManager.Data");

            return output;
        }
    }
}
