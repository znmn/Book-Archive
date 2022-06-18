namespace BookArchive
{
    partial class bookView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDone = new System.Windows.Forms.Button();
            this.pdfReader = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnDone, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pdfReader, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.28763F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.71237F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 431);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.BackColor = System.Drawing.Color.Cyan;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(3, 374);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(685, 54);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Selesai Membaca";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pdfReader
            // 
            this.pdfReader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfReader.Location = new System.Drawing.Point(3, 3);
            this.pdfReader.MinimumSize = new System.Drawing.Size(20, 20);
            this.pdfReader.Name = "pdfReader";
            this.pdfReader.Size = new System.Drawing.Size(685, 365);
            this.pdfReader.TabIndex = 2;
            // 
            // bookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(731, 511);
            this.Name = "bookView";
            this.Text = "Baca Buku";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.WebBrowser pdfReader;
    }
}