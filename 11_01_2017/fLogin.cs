using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _11_01_2017.DAO;
namespace _11_01_2017
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            txbUser.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txbUser.Text;
            string pass = txbPass.Text;
            if(Login(user,pass))
            {
                fMain frm = new fMain();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                txbUser.Focus();
                txbPass.Text = "";
            }
        }
        bool Login(string username,string password)
        {
            return AccountDAO.INSTANCE.Login(username,password);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txbUser_Enter(object sender, EventArgs e) { }

        private void txbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{TAB}");

            }
        }

        private void txbPass_Enter(object sender, EventArgs e) { }

        private void txbPass_KeyUp(object sender, KeyEventArgs e) { }

        private void txbUser_MouseDown(object sender, MouseEventArgs e) { }

        private void txbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }

        }

    }
}
