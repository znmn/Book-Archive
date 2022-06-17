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
    public partial class AdminLogin : UserControl
    {
        private Admin objAdmin = new Admin(); 
        private InitForm objParent;
        int idAdmin;
        public AdminLogin()
        {
            InitializeComponent();
        }
        public AdminLogin(InitForm objParent)
        {
            InitializeComponent();
            this.objParent = objParent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please enter UserName and Password", "Fill Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (objAdmin.Login(out idAdmin, UserName.Text, Password.Text))
            {
                this.Destroy();
                objParent.showBooks(idAdmin);
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password", "Invalid Credential", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void Destroy()
        {
            this.UserName.Text = "";
            this.Password.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            objParent.showStart();
        }
    }
}
