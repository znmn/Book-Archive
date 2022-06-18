using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookArchive
{
    public partial class bookView : MetroForm
    {
        listBooks objlstBooks;
        string bookPath = "";

        public bookView()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        public void setParent(listBooks p_parent)
        {
            objlstBooks = p_parent;
        }

        public void setBookTitle(string bookTitle)
        {
            this.Text = bookTitle;
        }

        public void readBook(string bookPath)
        {
            this.bookPath = bookPath;
            System.Diagnostics.Debug.WriteLine(bookPath);
            pdfReader.Navigate(bookPath);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
