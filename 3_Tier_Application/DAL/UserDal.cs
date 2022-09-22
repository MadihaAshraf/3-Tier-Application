using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;

namespace DAL
{
    public class UserDal
    {
        DbCon db = new DbCon();
        public bool dalAddUser(User u)
        {
            string insertquery = "insert into users (name , email) values ('" + u.Name + "','" + u.Email + "')";
            return db.UDI(insertquery);
        }

        public bool dalUpdateUser(User u)
        {
            string updatequery = "Update users set name = '" + u.Name + "', email = '" + u.Email + "' where id = " + u.Id + " ";
            return db.UDI(updatequery);
        }

        public bool dalDeleteUser(User u)
        {
            string Deletequery = "delete from users where id = '" + u.Id + "';";
            return db.UDI(Deletequery);
        }


        public DataTable dalGetAllUser()
        {
            return db.Search("SELECT * FROM users");
        }

        public DataTable dalSearchUser( User u)
        {
            return db.Search("SELECT * FROM users where id = '"+u.Id+"'");
        }
    }
}
