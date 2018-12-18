using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Model
{
    public class AdminModel
    {
        private int personId;
        private string personName;
        private string userName;
        private string passWord;
        private string email;

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

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
