using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_2017.DAO
{
    public class StaffInfoDAO
    {
        private static StaffInfoDAO instance;
        public static StaffInfoDAO INSTANCE
        {
            get { if (instance == null) instance = new StaffInfoDAO(); return StaffInfoDAO.instance; }
            private set { StaffInfoDAO.instance = value; }
        }
        public bool InsertStaff(string ten,string gioitinh,DateTime ngaysinh,string diachi,string sdt)
        {
            string query = string.Format("insert dbo.staffinfo (staffname,staffsex,staffbirth,staffaddress,staffphone) values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",ten,gioitinh,Convert.ToDateTime(ngaysinh),diachi,sdt);
           int result= DataProvider.INSTANCE.ExecuteNonQuery(query);
           return result > 0;
        }
        public bool EditStaff(string ten,string gioitinh,DateTime ngaysinh,string diachi,string sdt,int index)
        {
            string query = string.Format("update dbo.staffinfo set staffname=N'{0}',staffsex=N'{1}',staffbirth=N'{2}',staffaddress=N'{3}',staffphone=N'{4}' where staffID=N'{5}'",ten,gioitinh,Convert.ToDateTime(ngaysinh),diachi,sdt,index);
            int result = DataProvider.INSTANCE.ExecuteNonQuery(query);
            return result >0;//if result >0 then the return is true else it is false.
        }
        public bool DeleteStaff(string ten)
        {
            string query = string.Format("Delete dbo.staffinfo where staffname = N'{0}'", ten);
            int result = DataProvider.INSTANCE.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
