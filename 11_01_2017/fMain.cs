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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        void Reset()
        {
            textBox1.Text= textBox2.Text = textBox3.Text = textBox5.Text = textBox6.Text = "";
        }
        void LoadStaffInfo()
        {
            string query = "select staffid as [Mã nhân viên],staffname as [Tên nhân viên],staffsex as [Giới tính], StaffBirth as [Năm sinh],staffaddress as [Địa chỉ] ,staffphone as [SĐT] from dbo.staffinfo";
            dtgHeThong.DataSource = DataProvider.INSTANCE.ExecuteQuery(query);
        }
        private void dtgHeThong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //StaffInfoBinding();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgHeThong.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadStaffInfo();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {//Click vao nut he thong.
        }
        //Phan them nhan vien
        void AddStaff(string ten,string gioitinh,DateTime ngaysinh,string diachi,string sdt)
        {
             if(textBox2.Text=="")
            {
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên !"); textBox2.Focus();
            }
            else if(textBox3.Text=="")
            {
                MessageBox.Show("Vui lòng nhập giới tính nhân viên !"); textBox3.Focus();
            }
            else if(textBox5.Text=="")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhân viên !"); textBox5.Focus();
            }
            else if(textBox6.Text=="")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhân viên "); textBox6.Focus();
            }
            else
            {
                if (StaffInfoDAO.INSTANCE.InsertStaff(ten, gioitinh, ngaysinh, diachi, sdt))
                {
                    MessageBox.Show("Thêm tài khoản thành công! ");
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản không thành công !");
                }
                LoadStaffInfo();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
                string ten = textBox2.Text;
                string gioitinh = textBox3.Text;
                DateTime ngaysinh = Convert.ToDateTime(dateTimePicker1.Text);
                string diachi = textBox5.Text;
                string sdt = textBox6.Text;
                AddStaff(ten, gioitinh, ngaysinh, diachi, sdt);
        }
        //Bat dau muc sua nhan vien
        void UpdateStaff(string ten,string gioitinh,DateTime ngaysinh,string diachi,string sdt,int index)
        {
              if(textBox2.Text=="")
            {
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên !"); textBox2.Focus();
            }
            else if(textBox3.Text=="")
            {
                MessageBox.Show("Vui lòng nhập giới tính nhân viên !"); textBox3.Focus();
            }
            else if(textBox5.Text=="")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhân viên !"); textBox5.Focus();
            }
            else if(textBox6.Text=="")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhân viên "); textBox6.Focus();
            }
            else
              {
                  if (StaffInfoDAO.INSTANCE.EditStaff(ten,gioitinh,ngaysinh,diachi,sdt,index))
                  {
                      MessageBox.Show("Update thông tin nhân viên thành công! ");
                  }
                  else
                  {
                      MessageBox.Show("Update thông tin nhân viên KHÔNG thành công !");
                  }
                  LoadStaffInfo();
              }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa  !"); textBox1.Focus();
            }
            else
            {
                string hovaten = textBox2.Text;
                string gioitinh = textBox3.Text;
                DateTime ngaysinh = Convert.ToDateTime(dateTimePicker1.Text);
                string diachi = textBox5.Text;
                string sdt = textBox6.Text;
                int index = Convert.ToInt32(textBox1.Text);
                UpdateStaff(hovaten, gioitinh, ngaysinh, diachi, sdt, index);
            }
        }
        //Bat dau xoa nhan vien.
        void XoaNhanVien(string ten)
        {
            if(StaffInfoDAO.INSTANCE.DeleteStaff(ten))
            {
                MessageBox.Show("Xóa nhân viên thành công !");
            }
            else
            {
                MessageBox.Show("Xóa nhân viên KHÔNG thành công !");
            }
            LoadStaffInfo();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string ten = textBox2.Text;
            if(textBox2.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần xóa !");
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa " +textBox2.Text.ToString() + " ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                XoaNhanVien(ten);
            }
            Reset();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
             textBox1.Text= textBox2.Text = textBox3.Text = textBox5.Text = textBox6.Text = "";
            textBox4.Text = Convert.ToString(DateTime.Now);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            fAccountManagement ff = new fAccountManagement();
            this.Hide();
            ff.ShowDialog();
            this.Show();
        }

    }
}
