using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EnterpriseManagementSystem
{
    public partial class MainForm : Form
    {
        Thread th;
        public MainForm(string PersonName)
        {
            InitializeComponent();
            this.Text = "宿舍管理欢迎您：" + PersonName;
        }

        private void 人员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // th.Suspend();

            ManagerForm mfrf = ManagerForm.GetManagerForm();
            mfrf.ShowDialog();
        }

        /// <summary>
        /// 改变图片
        /// </summary>
        /// <param name="img">图片</param>
        /// <param name="millisecondsTimeOut">切换图片间隔时间</param>
        private void ChangeImage(Image img, int millisecondsTimeOut)
        {
            this.Invoke(new Action(() =>
            {
                pictureBox1.Image = img;
            })
                );
            Thread.Sleep(millisecondsTimeOut);
        }

        private void lunbo()
        {
            th = new Thread
                (
                    delegate ()
                    {
                        while(true)
                        {
                            //调用方法
                            ChangeImage(Image.FromFile(Application.StartupPath + "\\Img/green.jpg"), 1500);
                            ChangeImage(Image.FromFile(Application.StartupPath + "\\Img/white.jpg"), 1500);
                            ChangeImage(Image.FromFile(Application.StartupPath + "\\Img/purple.jpg"), 1500);
                        }
                    }
                );

            th.IsBackground = true;
            th.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lunbo();

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            th.Abort();//结束线程
        }
    }
}
