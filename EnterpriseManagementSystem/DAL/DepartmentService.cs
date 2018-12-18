using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DepartmentService
    {
        public List<Model.DepartmentModel> GetAllDepartmentList(bool isDel)
        {
            string sql = "select * from Department where IsDel = @isDel";

            SqlParameter p = new SqlParameter("IsDel", isDel);

            List<Model.DepartmentModel> depList = null;

            DataTable dt = SqlHelper.ExcuteTable(sql, p);

            if (dt.Rows.Count>0)
            {
                depList = new List<Model.DepartmentModel>();

                foreach (DataRow item in dt.Rows)
                {
                    Model.DepartmentModel dep = new Model.DepartmentModel();

                    DepartmentRowToPersonObj(item, dep);

                    depList.Add(dep);
                }
            }
            return depList;
        }

        public void DepartmentRowToPersonObj(DataRow row,Model.DepartmentModel temp)
        {
            temp.DepartmentId = (int)row["DepartmentId"];
            temp.Department = row["Department"].ToString();
            temp.IsDel = (bool)row["IsDel"];
        }
    }
}
