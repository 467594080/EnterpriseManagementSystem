using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class DepartmentManager
    {
        DepartmentService dep = new DepartmentService();

        public List<DepartmentModel> GetAllDepartmentList(bool isDel)
        {
            return dep.GetAllDepartmentList(isDel);
        }
    }
}
