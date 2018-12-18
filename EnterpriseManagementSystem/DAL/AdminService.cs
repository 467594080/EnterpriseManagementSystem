using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DAL
{
    public class AdminService
    {
        public int Login(string name,string password)
        {
            string sql = "SELECT COUNT(*) FROM Admin WHERE name=@name AND password =@password";

            SqlParameter[] ps =
            {
                new SqlParameter("name",name),
                new SqlParameter("password", password)
             };

            return SqlHelper.ExcuteScaler(sql, ps);
        }

        public Model.AdminModel Login(string username)
        {
            string sql = "SELECT * FROM Admin WHERE username = @name";

            SqlParameter[] ps =
            {
                new SqlParameter("name",username),
             };

            DataTable dt = SqlHelper.ExcuteTable(sql, ps);

            Model.AdminModel per= null;

            if (dt.Rows.Count>0)
            {
                per = new Model.AdminModel();
                LoginRowToLoginObj(dt.Rows[0], per);
            }

            return per;
        }

        //把数据转换为对象
        public void LoginRowToLoginObj(DataRow row,Model.AdminModel temp)
        {
            temp.PersonId = (int)row["AdminId"];
            temp.PersonName = (string)row["AdminName"];
            temp.UserName = (string)row["username"];
            temp.PassWord = (string)row["password"];
            //if (row["Email"] != typeof(DBNull) && string.IsNullOrEmpty(row["Email"].ToString()))
            //{
            //    temp.Email = (string)row["Email"];
            //}        
        }
    }
}
