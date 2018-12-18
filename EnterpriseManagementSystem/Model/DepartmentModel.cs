using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class DepartmentModel
    {
        private int departmentId;
        private string department;
        private bool isDel;

        public int DepartmentId
        {
            get
            {
                return departmentId;
            }

            set
            {
                departmentId = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }

            set
            {
                department = value;
            }
        }

        public bool IsDel
        {
            get
            {
                return isDel;
            }

            set
            {
                isDel = value;
            }
        }
    }
}
