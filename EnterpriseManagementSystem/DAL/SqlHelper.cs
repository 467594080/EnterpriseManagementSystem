using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DAL
{
    public class SqlHelper
    {
        //数据库连接字符串
        //第一种方法直接写在代码里
        //static readonly string connStr= "Data Source=PC-201610021601;Initial Catalog=Person;Integrated Security=True";
        //第二种方法，写在配置表里面方便维护与修改
        static readonly string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        //执行数据库命令的方法，获取结果的行数（数据行）
        public static int ExcuteScaler(string sql ,params SqlParameter[] ps)
        {
            //新建一个数据库连接通道
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                //打开数据库
                conn.Open();
                //实例化数据库命令
                SqlCommand command = new SqlCommand(sql, conn);
                //添加参数
                command.Parameters.AddRange(ps);
                //执行数据库命令
                return (int)command.ExecuteScalar();
            }
        }

        //执行数据库命令的方法，获取详细结果（表）
        public static DataTable ExcuteTable(string sql,params SqlParameter[] ps)
        {
            //实例化SqlDataAdapter对象
            SqlDataAdapter da = new SqlDataAdapter(sql, connStr);
            //添加参数
            da.SelectCommand.Parameters.AddRange(ps);
            //实例化一个数据表
            DataTable dt = new DataTable();
            //把查询到的数据表填充到表里面
            da.Fill(dt);

            return dt;
        }

        //执行增加，删除，修改的操作
        public static int ExecuteNonQuery(string sql, params SqlParameter[] ps)
        {
            //新建一个数据库连接通道
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                //打开数据库
                conn.Open();
                //实例化数据库命令
                SqlCommand command = new SqlCommand(sql, conn);
                //添加参数
                command.Parameters.AddRange(ps);
                //执行数据库命令
                return command.ExecuteNonQuery();
            }
        }
    }
}
