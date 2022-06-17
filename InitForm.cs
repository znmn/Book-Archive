using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace BookArchive
{
    public partial class InitForm : MetroForm
    {
        AdminLogin objAdminLogin;
        listBooks objlistBooks;
        //SqlDBHelper objDBHelper = new SqlDBHelper();
        public InitForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            initGuiComponent();

        }

        private void initGuiComponent()
        {            
            objAdminLogin = new AdminLogin(this);
            objAdminLogin.Dock = DockStyle.Fill;
            this.Controls.Add(objAdminLogin);

            objlistBooks = new listBooks(this);
            objlistBooks.Dock = DockStyle.Fill;
            this.Controls.Add(objlistBooks);
        }
        
        public void showAdminLogin()
        {
            changeFormName("Login Admin");
            objAdminLogin.BringToFront();
        }
        
        public void showBooks(int idAdmin)
        {
            //objAdminLogin.SendToBack();
            changeFormName("Daftar Buku");
            objlistBooks.BringToFront();
            objlistBooks.setIdAdmin(idAdmin);
        }
        
        public void listBook()
        {
            changeFormName("Daftar Buku");
            objlistBooks.BringToFront();
            objlistBooks.setIdAdmin();
        }
        
        public void showStart()
        {
            changeFormName("Arsip Buku");
            objlistBooks.SendToBack();
            objAdminLogin.SendToBack();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showAdminLogin();
        }
        
        private void btnUser_Click(object sender, EventArgs e)
        {
            listBook();
        }

        void changeFormName(string formName)
        {
            this.Text = formName;
            this.Refresh();
        }
    }
}
