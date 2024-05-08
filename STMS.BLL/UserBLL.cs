using STMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.BLL
{
    public class UserBLL
    {
        UserDAL userDAL = new UserDAL();
        
        public bool LoginSystem(string username, string password)
        {
            int userId = userDAL.LoginSystem(username, password);
            return userId > 0;
        }
    }
}
