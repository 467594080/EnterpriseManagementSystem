using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseManagementSystem
{
    public partial class ManagerForm : Form
    {
        static ManagerForm mf;
        static BLL.PersonManager pm = new BLL.PersonManager();
        static BLL.DepartmentManager dm = new BLL.DepartmentManager();
        static List<Model.PersonModel> perList;
        static List<Model.DepartmentModel> depList;

        public static ManagerForm GetManagerForm()
        {
            if (mf == null)
            {
                mf = new ManagerForm();
            }
            return mf;
        }

        private ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf = null;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            PersonDataGirdView.AutoGenerateColumns = false;
            PersonDataGirdView.Columns[6].Visible = false;

            perList = pm.GetAllPersonList(false);
            depList = dm.GetAllDepartmentList(false);

            PersonDataGirdView.DataSource = perList;
            cobDepartment.DisplayMember = "Department";
            cobDepartment.DataSource = depList;
            cobSex.DataSource = new List<string>{ "男","女"};

            cobReviseDepartment.DisplayMember = "Department";
            cobReviseDepartment.DataSource = dm.GetAllDepartmentList(false);
            cobReviseSex.DataSource = new List<string> { "男", "女" };

        }

        #region 新增员工
        private void 新增员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            Model.PersonModel newper = new Model.PersonModel();
            newper.PersonName = tbName.Text.Trim();
            newper.PersonSex = cobSex.Text.Trim();
            newper.PersonAge = int.Parse(tbAge.Text.Trim());
            newper.Department = cobDepartment.Text.Trim();
            newper.Address = tbAdress.Text.Trim();
            newper.PhoneNum = int.Parse(tbPhoneNum.Text.Trim());
            pm.AddPerson(newper);
            AddPanel.Visible = false;
            PersonDataGirdView.DataSource = pm.GetAllPersonList(false);
        }
        #endregion

        #region 删除信息
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = PersonDataGirdView.SelectedRows[0].Index;

            int id = (int)PersonDataGirdView.SelectedRows[0].Cells["PersonId"].Value;

            Model.PersonModel per = PersonDataGirdView.SelectedRows[0].DataBoundItem as Model.PersonModel;

            if (MessageBox.Show("确定要删除?", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (pm.DeletePerson(id) == 1)
                {
                    PersonDataGirdView.DataSource = pm.GetAllPersonList(false);

                    if (index > 0)
                    {
                        index--;
                        PersonDataGirdView.Rows[index].Selected = true;
                    }
                }
                else
                {
                    MessageBox.Show("删除失败", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (PersonDataGirdView.SelectedRows[0].DataBoundItem == null || PersonDataGirdView.SelectedRows[0].Cells["PersonId"].Value == null)
            {
                删除ToolStripMenuItem.Enabled = false;
            }
        }
        #endregion

        #region 修改信息Panel
        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevisePanel.Visible = true;

            tbReviseName.Text = (string)PersonDataGirdView.SelectedRows[0].Cells["PersonName"].Value.ToString().Trim();
            cobReviseSex.Text = (string)PersonDataGirdView.SelectedRows[0].Cells["PersonSex"].Value.ToString().Trim();
            tbReviseAge.Text = PersonDataGirdView.SelectedRows[0].Cells["PersonAge"].Value.ToString().Trim();
            cobReviseDepartment.Text = (string)PersonDataGirdView.SelectedRows[0].Cells["Department"].Value;
            tbReviseAdress.Text = (string)PersonDataGirdView.SelectedRows[0].Cells["Address"].Value.ToString().Trim();
            tbRevisePhone.Text = (string)PersonDataGirdView.SelectedRows[0].Cells["PhoneNum"].Value.ToString().Trim();
        }
        
        private void btnRevise_Click(object sender, EventArgs e)
        {
            //获取当前选中信息的ID
            int id = (int)PersonDataGirdView.SelectedRows[0].Cells["PersonId"].Value;
            int index = PersonDataGirdView.SelectedRows[0].Index;
            Model.PersonModel newper = new Model.PersonModel();
            newper.PersonId = id;
            newper.PersonName = tbReviseName.Text.Trim();
            newper.PersonSex = cobReviseSex.Text.Trim();
            newper.PersonAge = int.Parse(tbReviseAge.Text.Trim());
            newper.Department = cobReviseDepartment.Text.Trim();
            newper.Address = tbReviseAdress.Text.Trim();
            newper.PhoneNum = int.Parse(tbRevisePhone.Text.Trim());
            pm.RevisePerson(newper);

            RevisePanel.Visible = false;

            PersonDataGirdView.DataSource = pm.GetAllPersonList(false);

            PersonDataGirdView.Rows[index].Selected = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RevisePanel.Visible = false;
        }
        #endregion

        #region 搜索按钮
        //按名字搜索
        private void SearchName_Click(object sender, EventArgs e)
        {
            perList = pm.GetNamePersonList(false, Search.Text.Trim());
            PersonDataGirdView.DataSource = perList;
        }

        //按部门搜索
        private void SearchDepartment_Click(object sender, EventArgs e)
        {
            perList = pm.GetDepartmentPersonList(false, Search.Text.Trim());
            PersonDataGirdView.DataSource = perList;
        }

        #endregion

    }
}
