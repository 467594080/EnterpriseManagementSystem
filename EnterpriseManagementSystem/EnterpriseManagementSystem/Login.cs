using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterpriseManagementSystem
{
    public partial class Login : Form
    {
        BLL.AdminManager pm = new BLL.AdminManager();
        public Login()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (pm.Login(textBox1.Text.Trim(), textBox2.Text.Trim()))
            //{
            //    MessageBox.Show("登录成功");
            //}
            //else
            //{
            //    MessageBox.Show("登录失败");
            //}

            if (textBox1.Text == null || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("账户为空");
                return;
            }

            if (textBox2.Text == null || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("密码为空");
                return;
            }

            Model.AdminModel person = pm.Login(textBox1.Text.Trim());
            if (person == null)
            {
                MessageBox.Show( "不存在该账户");
            }
            else
            {
                MainForm mf = new MainForm(person.PersonName);
                mf.Show();
                this.Hide();
                MessageBox.Show("账号" + person.UserName + "登录成功");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
