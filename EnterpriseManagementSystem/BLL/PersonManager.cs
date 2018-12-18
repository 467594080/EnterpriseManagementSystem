using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class PersonManager
    {
        DAL.PersonService ps = new DAL.PersonService();

        //获取所有人员名单，传入一个是否在职的参数
        public List<Model.PersonModel> GetAllPersonList(bool isDel)
        {
            return ps.GetAllPersonList(isDel);
        }

        //添加一个人
        public int AddPerson(Model.PersonModel perModel)
        {
            return ps.AddPerson(perModel);
        }

        //修改信息
        public int RevisePerson(Model.PersonModel perModel)
        {
            return ps.RevisePerson(perModel);
        }

        //删除一个人，把他变为离职状态
        public int DeletePerson(int id)
        {
            return ps.DeletePerson(id);
        }

        //根据ID进行筛选
        public List<Model.PersonModel> GetIdPersonList(bool isDel, int id)
        {
            return ps.GetIdPersonList(isDel, id);
        }

        //根据名字进行筛选
        public List<Model.PersonModel> GetNamePersonList(bool isDel,string name)
        {
            return ps.GetNamePersonList(isDel, name);
        }

        //根据部门进行筛选
        public List<Model.PersonModel> GetDepartmentPersonList(bool isDel, string department)
        {
            return ps.GetDepartmentPersonList(isDel, department);
        }
    }
}
