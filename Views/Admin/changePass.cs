using BookArchive.Models;
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
    public partial class changePass : MetroForm
    {
        Admin objAdmin = new Admin();
        int idAdmin;
        listBooks objlstBooks;
        public changePass()
        {
            InitializeComponent();
        }
        
        public void setParent(listBooks p_parent)
        {
            objlstBooks = p_parent;
            this.idAdmin = Convert.ToInt32(objlstBooks.getIdAdmin());
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                MessageBox.Show("Tolong Isi Password Baru", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }else if(objAdmin.changePassword(idAdmin, tbPass.Text))
            {
                MessageBox.Show("Success Change Password", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed Change Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
