using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BookArchive
{
    public class SqlDBHelper
    {
        private SQLiteConnection conn;

        public SqlDBHelper()
        {
            this.conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["BookArchiveConn"].ConnectionString);
        }

        public bool ExecuteQuery(out DataTable dt, string query, CommandType cmdType, params SQLiteParameter[] parameters)
        {
            dt = new DataTable();
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.CommandType = cmdType;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    da.Fill(dt);
                    cmd.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                //return false;
                throw new Exception("SQL Query Error", ex);
            }
        }
        public int ExecuteScalar( string query)
        {
            conn.Close();
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    int res = Convert.ToInt32( cmd.ExecuteScalar());
                    conn.Close();
                    cmd.Dispose();
                    if (res >= 1) { return res; } else { return 0; }
                }
            }
            catch (Exception)
            {
                conn.Close();
                return 0;
            }
        }
        // Execute non query
        public bool ExecuteNonQuery(out string exception, string sql, CommandType cmdType, params SQLiteParameter[] parameters)
        {
            exception = "";
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    int res = cmd.ExecuteNonQuery();
                    //System.Diagnostics.Debug.WriteLine(res);
                    conn.Close();
                    cmd.Dispose();
                    if (res == 0)
                    {
                        exception = "No rows affected";
                        return false;
                    }
                    else { return true; }
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                exception = ex.Message;
                return false;
            }
        }
    }
}
