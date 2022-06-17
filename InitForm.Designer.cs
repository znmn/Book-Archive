namespace BookArchive
{
    partial class InitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitForm));
            this.pnlSplash = new MetroFramework.Controls.MetroPanel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.askLabel = new System.Windows.Forms.Label();
            this.pnlSplash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSplash
            // 
            this.pnlSplash.Controls.Add(this.btnUser);
            this.pnlSplash.Controls.Add(this.btnAdmin);
            this.pnlSplash.Controls.Add(this.askLabel);
            this.pnlSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSplash.HorizontalScrollbarBarColor = true;
            this.pnlSplash.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSplash.HorizontalScrollbarSize = 10;
            this.pnlSplash.Location = new System.Drawing.Point(20, 60);
            this.pnlSplash.Name = "pnlSplash";
            this.pnlSplash.Size = new System.Drawing.Size(732, 253);
            this.pnlSplash.TabIndex = 0;
            this.pnlSplash.VerticalScrollbarBarColor = true;
            this.pnlSplash.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSplash.VerticalScrollbarSize = 10;
            // 
            // btnUser
            // 
            this.btnUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUser.Location = new System.Drawing.Point(0, 97);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(732, 78);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "PENGUNJUNG";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdmin.Location = new System.Drawing.Point(0, 175);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(732, 78);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // askLabel
            // 
            this.askLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.askLabel.AutoSize = true;
            this.askLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.askLabel.Location = new System.Drawing.Point(290, 34);
            this.askLabel.Name = "askLabel";
            this.askLabel.Size = new System.Drawing.Size(152, 25);
            this.askLabel.TabIndex = 2;
            this.askLabel.Text = "Who Are You?";
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 333);
            this.Controls.Add(this.pnlSplash);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "InitForm";
            this.Resizable = false;
            this.Text = "Arsip Buku";
            this.pnlSplash.ResumeLayout(false);
            this.pnlSplash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlSplash;
        private System.Windows.Forms.Label askLabel;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnAdmin;
    }
}

