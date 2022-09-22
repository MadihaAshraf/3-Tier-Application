using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;
using DAL;

namespace BLL
{
    public class UserBLL
    {
        UserDal dalU = new UserDal();
        public bool AddUserbll(User u)
        {
            return dalU.dalAddUser(u);
        }

        public bool UpdateUserbll(User u)
        {
            return dalU.dalUpdateUser(u);
        }
        public bool DeleteUserbll(User u)
        {
            return dalU.dalDeleteUser(u);
        }

        public DataTable SearchUserbll(User u)
        {
            return dalU.dalSearchUser(u);
        }

        public DataTable GetallUserbll()
        {
            return dalU.dalGetAllUser();
        }


    }
}
