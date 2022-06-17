using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookArchive
{
    public partial class bookForm : MetroForm
    {
        bool isAdd = true;
        listBooks objlstBooks;
        string startPath;

        public bookForm()
        {
            InitializeComponent();
            KeyPressHandler();
        }
        
        void KeyPressHandler()
        {
            this.tbYear.KeyPress += numOnly_KeyPress;
            this.tbIsbn.KeyPress += numOnly_KeyPress;
        }
        public void setParent(listBooks p_parent)
        {
            objlstBooks = p_parent;
        }

        public void setDataForm(string isbn, string title, string author, string year, string path)
        {
            string realPath = Directory.GetCurrentDirectory() + @"\book\" + path;
            this.Text = "Edit Buku " + title;
            tbIsbn.Text = isbn;
            tbTitle.Text = title;
            tbAuthor.Text = author;
            tbYear.Text = year;
            tbPath.Text = realPath;
            startPath = realPath;
            btnSave.Text = "Update";
            this.isAdd = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbIsbn.Text == "" || tbTitle.Text == "" || tbAuthor.Text == "" || tbYear.Text == "" || tbPath.Text == "")
            {
                MessageBox.Show("Tolong isi Informasi yang diperlukan", "Fill Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string[] pdfPath = FileHelper.generatePdfPath();
            try
            {
                if (isAdd)
                {
                    CopyFile(pdfPath);
                    objlstBooks.addBook(tbIsbn.Text, tbTitle.Text, tbAuthor.Text, tbYear.Text, tbPath.Text);
                }
                else
                {
                    if (tbPath.Text.IndexOf(FileHelper.basePath) == -1)
                    {
                        File.Delete(this.startPath);
                        CopyFile(pdfPath);
                    }
                    else
                    {
                        tbPath.Text = tbPath.Text.getFileName();
                    }
                    objlstBooks.updateBook(tbIsbn.Text, tbTitle.Text, tbAuthor.Text, tbYear.Text, tbPath.Text);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                File.Delete(pdfPath[1]);
                return;
            }
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = selectFileDialog.FileName;
                if (fileName.EndsWith(".pdf"))
                {
                    if (File.Exists(fileName))
                    {
                        tbPath.Text = fileName;
                    }
                }
                else
                {
                    MessageBox.Show("File yang anda pilih bukan file PDF");
                }
            }
        }
        
        private void CopyFile(string[] pdfPath)
        {
            File.Copy(tbPath.Text, pdfPath[1]);
            tbPath.Text = pdfPath[0];
        }

        private void numOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
    // Github : https://github.com/znmn/
}
