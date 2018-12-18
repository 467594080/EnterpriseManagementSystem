using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class PersonModel
    {
        private int personId;
        private string personName;
        private string personSex;
        private int personAge;
        private string department;
        private string address;
        private int phoneNum;
        private bool isDel;

        public int PersonId
        {
            get
            {
                return personId;
            }

            set
            {
                personId = value;
            }
        }

        public string PersonName
        {
            get
            {
                return personName;
            }

            set
            {
                personName = value;
            }
        }

        public string PersonSex
        {
            get
            {
                return personSex;
            }

            set
            {
                personSex = value;
            }
        }

    public int PersonAge
        {
            get
            {
                return personAge;
            }

            set
            {
                personAge = value;
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

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public int PhoneNum
        {
            get
            {
                return phoneNum;
            }

            set
            {
                phoneNum = value;
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
