using BookArchive.Models;
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
    public partial class listBooks : UserControl
    {
        InitForm objParent;
        Books objBooks = new Books();
        bookForm frmBook;
        changePass frmPass;
        bookView vwBook;
        DataTable dtBooks = new DataTable();
        int? idAdmin;
        string idBook;
        bool isAdmin;
        public listBooks()
        {
            InitializeComponent();
        }
        public listBooks(InitForm objParent)
        {
            InitializeComponent();
            this.objParent = objParent;
            fillBooksData();
        }
        
        public void setIdAdmin(int idAdmin)
        {
            this.idAdmin = idAdmin;
            edit.Visible = true;
            delete.Visible = true;
            read.Visible = false;
            btnLogout.Visible = true;
            btnAdd.Visible = true;
            //btnBack.Visible = true;
            btnBack.Text = "Ganti Password";
            this.isAdmin = true;
        }
        public void setIdAdmin()
        {
            this.idAdmin = null;
            edit.Visible = false;
            delete.Visible = false;
            read.Visible = true;
            btnLogout.Visible = false;
            btnAdd.Visible = false;
            //btnBack.Visible = true;
            btnBack.Text = "Kembali ke Menu Utama";
            this.isAdmin = false;
        }
        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            idAdmin = null;
            objParent.showStart();
        }
        
        public void fillBooksData()
        {
            dtBooks.Clear();
            dtBooks = objBooks.GetBooks();
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.DataSource = dtBooks;
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.RowIndex != dtBooks.Rows.Count)
            {
                if (e.ColumnIndex == 6)  // edit
                {
                    frmBook = new bookForm();
                    frmBook.setParent(this);
                    idBook = dtBooks.Rows[e.RowIndex]["book_id"].ToString();
                    string isbn = dtBooks.Rows[e.RowIndex]["isbn"].ToString();
                    string title = dtBooks.Rows[e.RowIndex]["title"].ToString();
                    string author = dtBooks.Rows[e.RowIndex]["author"].ToString();
                    string year = dtBooks.Rows[e.RowIndex]["year"].ToString(); 
                    string path = dtBooks.Rows[e.RowIndex]["path"].ToString();


                    frmBook.setDataForm(isbn, title, author, year, path);
                    frmBook.ShowDialog(this);
                    //frmBook.Visible = true;
                }
                else if (e.ColumnIndex == 7) // hapus
                {
                    string idBook = dtBooks.Rows[e.RowIndex]["book_id"].ToString();
                    string title = dtBooks.Rows[e.RowIndex]["title"].ToString();
                    string path = dtBooks.Rows[e.RowIndex]["path"].ToString();
                    DialogResult dialogResult = MessageBox.Show("Hapus Buku " + title + "?", "Konfirmasi Hapus Buku", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        path.deletePdf();
                        objBooks.deleteBook(idBook);
                        this.fillBooksData();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else if (e.ColumnIndex == 8) // baca
                {
                    vwBook = new bookView();
                    vwBook.setParent(this);
                    string path = dtBooks.Rows[e.RowIndex]["path"].ToString();
                    string realPath = path.pdfNametoPath();
                    string title = dtBooks.Rows[e.RowIndex]["title"].ToString();
                    vwBook.setBookTitle(title);
                    vwBook.readBook(realPath);
                    vwBook.ShowDialog(this);
                }
            }

        }

        public void addBook(string isbn, string title, string author, string year, string path)
        {
            objBooks.insertBook(isbn, title, author, year, path);
            this.fillBooksData();
        }

        public void updateBook(string isbn, string title, string author, string year, string path)
        {
            objBooks.updateBook(idBook, isbn, title, author, year, path);
            this.fillBooksData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBook = new bookForm();
            frmBook.setParent(this);
            frmBook.ShowDialog(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.isAdmin)
            {
                frmPass = new changePass(idAdmin);
                frmPass.setParent(this);
                frmPass.ShowDialog(this);
            }
            else
            {
                objParent.showStart();
            }
        }
    }
}
