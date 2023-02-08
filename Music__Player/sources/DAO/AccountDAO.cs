using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) { 
                    instance = new AccountDAO(); 
                }
                return instance;
            }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord) {
            try
            {
                string query = $"Login @userName = {userName}, @passWord = {passWord}";

                //int result = DataProviderDAO.Instance.ExecuteNonQuery(query);
                //Insert, update

                DataTable results = DataProviderDAO.Instance.ExecuteQuery(query);
                
                return results.Rows.Count > 0;
            } catch
            {
                return false;
            }
        }

        public bool Signin(string userName, string passWord, string displayName)
        {
            try
            {
                string query = $"INSERT INTO Account(DisplayName, UserName, PassWord)\r\nVALUES ('{displayName}','{userName}', '{passWord}')";
                int result = DataProviderDAO.Instance.ExecuteNonQuery(query);
                return result > 0;
            } catch 
            {
                return false; 
            }
        }

    }
}
