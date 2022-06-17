using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookArchive.Models
{
    public class Books
    {
        SqlDBHelper objSqlDb = new SqlDBHelper();
        public Books()
        {
            
        }

        public DataTable GetBooks()
        {
            DataTable dt;
            string query = "select row_number(*) over(order by b.title) as num, b.* from books b order by b.title";
            objSqlDb.ExecuteQuery(out dt, query, CommandType.Text);
            return dt;
        }
        
        public bool deleteBook(string idBook)
        {
            string ex;
            string query = "DELETE FROM books WHERE book_id = " + idBook;
            bool res = objSqlDb.ExecuteNonQuery(out ex, query, CommandType.Text);
            return res;
        }
        public bool insertBook(string isbn, string title, string author, string year, string path)
        {
            string ex;
            string query = "INSERT INTO books (isbn, title, author, year, path) VALUES ('{0}','{1}','{2}','{3}','{4}')";
            query = string.Format(query, isbn, title, author, year, path);
            bool res = objSqlDb.ExecuteNonQuery(out ex, query, CommandType.Text);
            if (ex.ToLower().Contains("unique"))
            {
                throw new Exception("Data buku Telah Ada");
            }else if(ex != "")
            {
                throw new Exception(ex);
            }
            return res;
        }
        public bool updateBook(string idBook, string isbn, string title, string author, string year, string path)
        {
            string ex;
            string query = "UPDATE books SET isbn = '{0}', title = '{1}', author = '{2}', year = '{3}', path = '{4}' WHERE book_id = {5}";
            query = string.Format(query, isbn, title, author, year, path, idBook);
            bool res = objSqlDb.ExecuteNonQuery(out ex, query, CommandType.Text);
            if (ex.ToLower().Contains("unique"))
            {
                throw new Exception("Data buku Telah Ada");
            }else if(ex != "")
            {
                throw new Exception(ex);
            }
            return res;
        }

    }
}
