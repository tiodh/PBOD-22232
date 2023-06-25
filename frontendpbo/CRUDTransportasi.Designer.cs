namespace frontendpbo
{
    partial class CRUDTransportasi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateTransportasi = new System.Windows.Forms.Button();
            this.IDTransportasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NamaTransportasi = new System.Windows.Forms.TextBox();
            this.DeskripsiTransportasi = new System.Windows.Forms.TextBox();
            this.JenisTransportasi = new System.Windows.Forms.TextBox();
            this.SearchTransportasi = new System.Windows.Forms.Button();
            this.TampilanData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteTransportasi = new System.Windows.Forms.Button();
            this.UpdateTransportasi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TampilData = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TampilData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(106)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(18, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 532);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 229);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(18, 15, 18, 15);
            this.panel4.Size = new System.Drawing.Size(1163, 282);
            this.panel4.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.SearchTransportasi);
            this.panel2.Controls.Add(this.TampilanData);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.DeleteTransportasi);
            this.panel2.Controls.Add(this.UpdateTransportasi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(18, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 252);
            this.panel2.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.CreateTransportasi);
            this.panel5.Controls.Add(this.IDTransportasi);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.NamaTransportasi);
            this.panel5.Controls.Add(this.DeskripsiTransportasi);
            this.panel5.Controls.Add(this.JenisTransportasi);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(509, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(618, 252);
            this.panel5.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID TRANSPORTASI             :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "DESKRIPSI TRANSPORTASI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "JENIS TRANSPORTASI        :";
            // 
            // CreateTransportasi
            // 
            this.CreateTransportasi.BackColor = System.Drawing.Color.Green;
            this.CreateTransportasi.Location = new System.Drawing.Point(18, 169);
            this.CreateTransportasi.Name = "CreateTransportasi";
            this.CreateTransportasi.Size = new System.Drawing.Size(124, 34);
            this.CreateTransportasi.TabIndex = 10;
            this.CreateTransportasi.Text = "CREATE DATA";
            this.CreateTransportasi.UseVisualStyleBackColor = false;
            // 
            // IDTransportasi
            // 
            this.IDTransportasi.Location = new System.Drawing.Point(207, 8);
            this.IDTransportasi.Name = "IDTransportasi";
            this.IDTransportasi.Size = new System.Drawing.Size(363, 23);
            this.IDTransportasi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAMA TRANSPORTASI      :";
            // 
            // NamaTransportasi
            // 
            this.NamaTransportasi.Location = new System.Drawing.Point(207, 44);
            this.NamaTransportasi.Name = "NamaTransportasi";
            this.NamaTransportasi.Size = new System.Drawing.Size(363, 23);
            this.NamaTransportasi.TabIndex = 7;
            // 
            // DeskripsiTransportasi
            // 
            this.DeskripsiTransportasi.Location = new System.Drawing.Point(207, 118);
            this.DeskripsiTransportasi.Multiline = true;
            this.DeskripsiTransportasi.Name = "DeskripsiTransportasi";
            this.DeskripsiTransportasi.Size = new System.Drawing.Size(363, 85);
            this.DeskripsiTransportasi.TabIndex = 9;
            // 
            // JenisTransportasi
            // 
            this.JenisTransportasi.Location = new System.Drawing.Point(207, 82);
            this.JenisTransportasi.Name = "JenisTransportasi";
            this.JenisTransportasi.Size = new System.Drawing.Size(363, 23);
            this.JenisTransportasi.TabIndex = 8;
            // 
            // SearchTransportasi
            // 
            this.SearchTransportasi.Location = new System.Drawing.Point(362, 61);
            this.SearchTransportasi.Name = "SearchTransportasi";
            this.SearchTransportasi.Size = new System.Drawing.Size(75, 22);
            this.SearchTransportasi.TabIndex = 15;
            this.SearchTransportasi.Text = "SEARCH";
            this.SearchTransportasi.UseVisualStyleBackColor = true;
            this.SearchTransportasi.Click += new System.EventHandler(this.SearchTransportasi_Click);
            // 
            // TampilanData
            // 
            this.TampilanData.Location = new System.Drawing.Point(29, 62);
            this.TampilanData.Name = "TampilanData";
            this.TampilanData.Size = new System.Drawing.Size(308, 23);
            this.TampilanData.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "TAMPILKAN DATA BERDASARKAN";
            // 
            // DeleteTransportasi
            // 
            this.DeleteTransportasi.BackColor = System.Drawing.Color.Red;
            this.DeleteTransportasi.Location = new System.Drawing.Point(212, 169);
            this.DeleteTransportasi.Name = "DeleteTransportasi";
            this.DeleteTransportasi.Size = new System.Drawing.Size(124, 34);
            this.DeleteTransportasi.TabIndex = 12;
            this.DeleteTransportasi.Text = "DELETE DATA";
            this.DeleteTransportasi.UseVisualStyleBackColor = false;
            this.DeleteTransportasi.Click += new System.EventHandler(this.DeleteTransportasi_Click);
            // 
            // UpdateTransportasi
            // 
            this.UpdateTransportasi.BackColor = System.Drawing.Color.Yellow;
            this.UpdateTransportasi.Location = new System.Drawing.Point(26, 169);
            this.UpdateTransportasi.Name = "UpdateTransportasi";
            this.UpdateTransportasi.Size = new System.Drawing.Size(124, 34);
            this.UpdateTransportasi.TabIndex = 11;
            this.UpdateTransportasi.Text = "UPDATE DATA";
            this.UpdateTransportasi.UseVisualStyleBackColor = false;
            this.UpdateTransportasi.Click += new System.EventHandler(this.UpdateTransportasi_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TampilData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(18, 15, 18, 15);
            this.panel3.Size = new System.Drawing.Size(1163, 229);
            this.panel3.TabIndex = 16;
            // 
            // TampilData
            // 
            this.TampilData.AllowUserToAddRows = false;
            this.TampilData.AllowUserToDeleteRows = false;
            this.TampilData.BackgroundColor = System.Drawing.Color.White;
            this.TampilData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TampilData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TampilData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.TampilData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TampilData.GridColor = System.Drawing.Color.White;
            this.TampilData.Location = new System.Drawing.Point(18, 15);
            this.TampilData.Name = "TampilData";
            this.TampilData.ReadOnly = true;
            this.TampilData.RowHeadersWidth = 62;
            this.TampilData.RowTemplate.Height = 25;
            this.TampilData.Size = new System.Drawing.Size(1127, 199);
            this.TampilData.TabIndex = 5;
            this.TampilData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TampilData_CellContentClick_1);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Pilih";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // CRUDTransportasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 562);
            this.Controls.Add(this.panel1);
            this.Name = "CRUDTransportasi";
            this.Padding = new System.Windows.Forms.Padding(18, 15, 18, 15);
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TampilData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView TampilData;
        private Panel panel2;
        private Button SearchTransportasi;
        private TextBox TampilanData;
        private Label label6;
        private TextBox IDTransportasi;
        private TextBox NamaTransportasi;
        private TextBox JenisTransportasi;
        private TextBox DeskripsiTransportasi;
        private Label label1;
        private Label label2;
        private Button CreateTransportasi;
        private Button DeleteTransportasi;
        private Label label3;
        private Label label4;
        private Button UpdateTransportasi;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private DataGridViewButtonColumn Edit;
    }
}