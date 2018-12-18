using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace BLL
{
    public class AdminManager
    {
        DAL.AdminService ps = new DAL.AdminService();

        public bool Login(string name,string password)
        {
            return ps.Login(name, password) == 1;
        }

        public Model.AdminModel Login(string username)
        {
            return ps.Login(username);
        }
    }
}
