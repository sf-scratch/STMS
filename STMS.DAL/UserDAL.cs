using STMS.Models.DModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.DAL
{
    public class UserDAL : BaseDAL<UserInfo>
    {
        public int LoginSystem(string username, string password)
        {
            string strWhere = "UserName=@userName and UserPwd=@userPwd and UserState=1 and IsDeleted=0";
            SqlParameter[] parameter =
            {
                new SqlParameter("@userName", username), 
                new SqlParameter("@userPwd", password)
            };
            UserInfo user = GetModel(strWhere, "UserId", parameter);
            if (user !=  null)
            {
                return user.UserId;
            }
            return 0;
        }
    }
}
