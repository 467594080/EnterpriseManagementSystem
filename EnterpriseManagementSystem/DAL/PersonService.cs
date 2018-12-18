using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class PersonService
    {
        //获取所有人的信息
        public List<Model.PersonModel> GetAllPersonList(bool isDel)
        {
            string sql = "select * from Person where IsDel = @isDel";

            SqlParameter p = new SqlParameter("isDel", isDel);

            List<Model.PersonModel> perList = null;

            DataTable dt = SqlHelper.ExcuteTable(sql, p);

            if (dt.Rows.Count>0)
            {
                perList = new List<Model.PersonModel>();

                foreach (DataRow row in dt.Rows)
                {
                    Model.PersonModel per = new Model.PersonModel();
                    PersonRowToPersonObj(row, per);
                    perList.Add(per);
                }
            }
            return perList;
        }

        //增加一个人
        public int AddPerson(Model.PersonModel perModel)
        {
            string sql = "insert into Person values (@PersonName,@PersonSex,@PersonAge,@Department,@Address,@PhoneNum,default)";

            SqlParameter[] ps =
                {
                    new SqlParameter("PersonName", perModel.PersonName),
                    new SqlParameter("PersonSex", perModel.PersonSex),
                    new SqlParameter("PersonAge", perModel.PersonAge),
                    new SqlParameter("Department", perModel.Department),
                    new SqlParameter("Address", perModel.Address),
                    new SqlParameter("PhoneNum", perModel.PhoneNum),
            };

            return SqlHelper.ExecuteNonQuery(sql, ps);
        }

        //修改一个人的信息
        public int RevisePerson(Model.PersonModel perModel)
        {
            string sql = "update Person set PersonName = @PersonName,PersonSex=@PersonSex,PersonAge=@PersonAge,Department=@Department,Address=@Address,PhoneNum=@PhoneNum where PersonId = @PersonId";

            SqlParameter[] ps = {
                new SqlParameter("PersonId", perModel.PersonId),
                new SqlParameter("PersonName", perModel.PersonName),
                new SqlParameter("PersonSex", perModel.PersonSex),
                new SqlParameter("PersonAge", perModel.PersonAge),
                new SqlParameter("Department", perModel.Department),
                new SqlParameter("Address", perModel.Address),
                new SqlParameter("PhoneNum", perModel.PhoneNum),
            };

            return SqlHelper.ExecuteNonQuery(sql, ps);
        }

        //删除一个人的信息
        public int DeletePerson(int id)
        {
            string sql = "update Person set IsDel = 1 where PersonId = @id";

            SqlParameter p = new SqlParameter("id",id);

            return SqlHelper.ExecuteNonQuery(sql, p);
        }

        //根据Id筛选
        public List<Model.PersonModel> GetIdPersonList(bool isDel, int id)
        {
            string sql = "select * from Person where IsDel = @isDel and PersonName = @id";

            SqlParameter[] ps =
            {
                new SqlParameter("isDel",isDel),
                new SqlParameter("id",id)
            };

            List<Model.PersonModel> perList = null;

            DataTable dt = SqlHelper.ExcuteTable(sql, ps);

            if (dt.Rows.Count > 0)
            {
                perList = new List<Model.PersonModel>();

                foreach (DataRow row in dt.Rows)
                {
                    Model.PersonModel per = new Model.PersonModel();
                    PersonRowToPersonObj(row, per);
                    perList.Add(per);
                }
            }
            return perList;
        }

        //根据名字筛选
        public List<Model.PersonModel> GetNamePersonList(bool isDel, string name)
        {
            string sql = "select * from Person where IsDel = @isDel and PersonName = @name";

            SqlParameter[] ps =
            {
                new SqlParameter("isDel",isDel),
                new SqlParameter("name",name)
            };

            List<Model.PersonModel> perList = null;

            DataTable dt = SqlHelper.ExcuteTable(sql, ps);

            if (dt.Rows.Count > 0)
            {
                perList = new List<Model.PersonModel>();

                foreach (DataRow row in dt.Rows)
                {
                    Model.PersonModel per = new Model.PersonModel();
                    PersonRowToPersonObj(row, per);
                    perList.Add(per);
                }
            }
            return perList;
        }


        //根据名字筛选
        public List<Model.PersonModel> GetDepartmentPersonList(bool isDel, string department)
        {
            string sql = "select * from Person where IsDel = @isDel and Department = @department";

            SqlParameter[] ps =
            {
                new SqlParameter("isDel",isDel),
                new SqlParameter("department",department)
            };

            List<Model.PersonModel> perList = null;

            DataTable dt = SqlHelper.ExcuteTable(sql, ps);

            if (dt.Rows.Count > 0)
            {
                perList = new List<Model.PersonModel>();

                foreach (DataRow row in dt.Rows)
                {
                    Model.PersonModel per = new Model.PersonModel();
                    PersonRowToPersonObj(row, per);
                    perList.Add(per);
                }
            }
            return perList;
        }


        //把数据转换为对象
        public void PersonRowToPersonObj(DataRow row, Model.PersonModel temp)
        {
            temp.PersonId = (int)row["PersonId"]; 
            temp.PersonName = (string)row["PersonName"];
            temp.PersonSex = (string)row["PersonSex"];
            temp.PersonAge = (int)row["PersonAge"];
            temp.Department = (string)row["Department"];
            temp.Address = (string)row["Address"];
            temp.PhoneNum = (int)row["PhoneNum"];
            temp.IsDel = (bool)row["IsDel"];
        }
    }
}

