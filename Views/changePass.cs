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
        int admin_id;
        listBooks objlstBooks;
        public changePass()
        {
            InitializeComponent();
        }
        
        public changePass(int? admin_id)
        {
            InitializeComponent();
            this.admin_id = Convert.ToInt32(admin_id);
        }
        
        public void setParent(listBooks p_parent)
        {
            objlstBooks = p_parent;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                MessageBox.Show("Tolong Isi Password Baru", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }else if(objAdmin.changePassword(admin_id, tbPass.Text))
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
