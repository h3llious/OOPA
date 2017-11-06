using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace _11_01_2017.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO INSTANCE
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username,string password)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.INSTANCE.ExecuteQuery(query, new object[]{username,password});
            return result.Rows.Count > 0;
        }
        public bool InsertAccount(string name, string displayName,string pass, int type)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, DisplayName,password, Type ) VALUES  ( N'{0}', N'{1}', N'{2}',{3})", name, displayName,pass, type);
            int result = DataProvider.INSTANCE.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(string name, string displayName,string pass, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{0}',password=N'{1}', Type = {2} WHERE UserName = N'{3}'", displayName, pass,type,name);
            int result = DataProvider.INSTANCE.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete Account where UserName = N'{0}'", name);
            int result = DataProvider.INSTANCE.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ResetPassword(string name)
        {
            string query = string.Format("update dbo.account set password = N'defaultpassword' where UserName = N'{0}'", name);
            int result = DataProvider.INSTANCE.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
