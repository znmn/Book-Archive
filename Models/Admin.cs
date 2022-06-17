using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BookArchive.Models
{
    public class Admin
    {
        SqlDBHelper objDBHelper = new SqlDBHelper();
        public Admin() 
        {
            
        }
        
        public bool Login(out int admin_id, string userName, string password)
        {
            admin_id = 0;
            //string query = "SELECT COUNT(*) FROM admins WHERE username = '" + userName + "' AND password = '" + password + "'";
            string query = "SELECT admin_id FROM admins WHERE username = '" + userName + "' AND password = '" + password + "'";
            int execute = objDBHelper.ExecuteScalar(query);
            if (execute >= 1)
            {
                admin_id = execute;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool changePassword(int admin_id, string newPassword)
        {
            string ex;
            string query = "UPDATE admins SET password = '" + newPassword + "' WHERE admin_id = " + admin_id;
            return objDBHelper.ExecuteNonQuery(out ex, query, CommandType.Text);
        }
    }
}
