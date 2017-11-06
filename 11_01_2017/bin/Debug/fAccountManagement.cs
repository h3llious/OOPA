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
using _11_01_2017.DTO;
namespace _11_01_2017
{
    public partial class fAccountManagement : Form
    {
        public fAccountManagement()
        {
            InitializeComponent();
            LoadAccount();
        }
        void LoadAccount()
        {
            //string query = "select *from dbo.account where type='0'";
            string query = "select accountid as [Mã Tài Khoản], username as [Tên người dùng], displayname as [Tên hiển thị], password as[Mật khẩu], type as [Loại tài khoản] from dbo.account ";
            //Show Admin Account Only
            dtgQLTKNV.DataSource = DataProvider.INSTANCE.ExecuteQuery(query);
            tbConfirmPass.Text = "";
        }
        void ResetData()
        {
            tbUserName.Text = tbPassWord.Text = tbDisplayName.Text = tbConfirmPass.Text = "";
        }
        private void dtgQLTKNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dtgQLTKNV.Rows[e.RowIndex];
                tbAccountID.Text = row.Cells[0].Value.ToString();
                tbUserName.Text = row.Cells[1].Value.ToString();
                tbDisplayName.Text = row.Cells[2].Value.ToString();
                tbPassWord.Text = row.Cells[3].Value.ToString();
                tbConfirmPass.Text = "";
            }
        }
        void AddCount(string username, string displayname,string pass, int type)
        {
            if(tbUserName.Text=="")
            {
                MessageBox.Show("Vui lòng nhập vào Username !");
                tbUserName.Focus();
            }
            else if(tbDisplayName.Text=="")
            {
                MessageBox.Show("Vui lòng nhập vào Displayname !");
                tbDisplayName.Focus();
            }
            else if(tbPassWord.Text=="")
            {
                MessageBox.Show("Vui lòng nhập vào Mật khẩu !");
                tbPassWord.Focus();
            }
            else if ((tbConfirmPass.Text.ToString().CompareTo(tbPassWord.Text.ToString())) != 0)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                tbConfirmPass.Text = "";
                tbConfirmPass.Focus();
            }
            else  if((int)numericUpDown1.Value==1)
            {
                 if (MessageBox.Show("Bạn có thật sự muốn thêm một Admin mới ? ", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                 {
                     if (AccountDAO.INSTANCE.InsertAccount(username, displayname, pass, type))
                     {
                         MessageBox.Show("Thêm tài khoản Admin thành công! \nAdmin sẽ không được hiển thị ở đây !");
                     }
                     else
                     {
                         MessageBox.Show("Thêm tài khoản không thành công !");
                     }
                     LoadAccount();
                     ResetData();
                 }
            }
            else
            {
                if (AccountDAO.INSTANCE.InsertAccount(username, displayname,pass, type))
                {
                    MessageBox.Show("Thêm tài khoản thành công! ");
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản không thành công !");
                }
                LoadAccount();
                ResetData();
            }
        }
        private void btnThemTl_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string displayname = tbDisplayName.Text;
            string password = tbPassWord.Text;
            int type =(int) numericUpDown1.Value;
            AddCount(username, displayname,password, type);
        }
        void UpdateAccount(string username,string displayname,int type,string pass)
        {
            if (tbUserName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vào Username !");
                tbUserName.Focus();
            }
            else if (tbDisplayName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vào Displayname !");
                tbDisplayName.Focus();
            }
            else if (tbPassWord.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vào Mật khẩu !");
                tbPassWord.Focus();
            }
            else if ((tbConfirmPass.Text.ToString().CompareTo(tbPassWord.Text.ToString())) != 0)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                tbConfirmPass.Text = "";
                tbConfirmPass.Focus();
            }
            else if((int)numericUpDown1.Value==1)
            {
                 if (MessageBox.Show("Bạn có thật sự muốn chuyển  "+tbUserName.Text.ToString()+" thành Admin ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                 {
                     if (AccountDAO.INSTANCE.UpdateAccount(username, displayname, pass, type))
                     {
                         MessageBox.Show("Update tài khoản thành công! ");
                     }
                     else
                     {
                         MessageBox.Show("Update tài khoản không thành công!");
                     }
                     LoadAccount();
                 }
            }
            else
            {
                if (AccountDAO.INSTANCE.UpdateAccount(username, displayname, pass, type))
                {
                    MessageBox.Show("Update tài khoản thành công! ");
                }
                else
                {
                    MessageBox.Show("Update tài khoản không thành công!");
                }
                LoadAccount();
            }
        }
        private void btnSuaTk_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string displayname = tbDisplayName.Text;
            string password = tbPassWord.Text;
            int type = (int)numericUpDown1.Value;
            UpdateAccount(username, displayname, type,password);
        }
        void DeleteAccount(string username)
        {
            if (tbUserName.Text == "")
            {
                MessageBox.Show("Vui lòng chọn người dùng cần được xóa !");
                tbUserName.Focus();
            }
            else
            {
                if (AccountDAO.INSTANCE.DeleteAccount(username))
                {
                    MessageBox.Show("Xóa tài khoản thành công! ");
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản không thành công!");
                }
                LoadAccount();
            }
        }
        private void btnXoaTk_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            if (tbUserName.Text == "")
            {
                MessageBox.Show("Vui lòng chọn người dùng cần được xóa !");
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa " + tbUserName.Text.ToString() + " ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    DeleteAccount(username);
                }
            }
            ResetData();
        }
        void ResetPass(string username)
        {
            if(tbUserName.Text=="")
            {
                MessageBox.Show("Vui lòng chọn người dùng !");
                tbUserName.Focus();
            }
            else
            {
                if (AccountDAO.INSTANCE.ResetPassword(username))
                {
                    MessageBox.Show("Đặt lại mật khẩu mặt định thành công!");
                }
                else
                {
                    MessageBox.Show("Đặt lại mật khẩu không thành công! ");
                }
            }
        }
        private void btnDoiMk_Click(object sender, EventArgs e)
        {
            string ten = tbUserName.Text;
            ResetPass(ten);
            LoadAccount();
        }
        private void btnQLNVReset_Click(object sender, EventArgs e)
        {
            tbUserName.Text = tbDisplayName.Text = tbPassWord.Text = tbConfirmPass.Text = "";
            numericUpDown1.Value = 0;
            tbUserName.Focus();
        }
    }
}
