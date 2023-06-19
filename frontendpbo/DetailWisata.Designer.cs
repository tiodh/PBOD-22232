namespace frontendpbo
{
    partial class DetailWisata
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dWisata1 = new DWisata();
            dWisata2 = new DWisata();
            dWisata3 = new DWisata();
            dWisata4 = new DWisata();
            dWisata5 = new DWisata();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 41);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 1;
            label1.Text = "DETAIL WISATA";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(dWisata1);
            flowLayoutPanel1.Controls.Add(dWisata2);
            flowLayoutPanel1.Controls.Add(dWisata3);
            flowLayoutPanel1.Controls.Add(dWisata4);
            flowLayoutPanel1.Controls.Add(dWisata5);
            flowLayoutPanel1.Location = new Point(12, 143);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1398, 822);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // dWisata1
            // 
            dWisata1.Dock = DockStyle.Top;
            dWisata1.Location = new Point(3, 3);
            dWisata1.Name = "dWisata1";
            dWisata1.Size = new Size(1327, 350);
            dWisata1.TabIndex = 0;
            // 
            // dWisata2
            // 
            dWisata2.Dock = DockStyle.Top;
            dWisata2.Location = new Point(3, 359);
            dWisata2.Name = "dWisata2";
            dWisata2.Size = new Size(1327, 350);
            dWisata2.TabIndex = 1;
            // 
            // dWisata3
            // 
            dWisata3.Dock = DockStyle.Top;
            dWisata3.Location = new Point(3, 715);
            dWisata3.Name = "dWisata3";
            dWisata3.Size = new Size(1327, 350);
            dWisata3.TabIndex = 2;
            // 
            // dWisata4
            // 
            dWisata4.Dock = DockStyle.Top;
            dWisata4.Location = new Point(3, 1071);
            dWisata4.Name = "dWisata4";
            dWisata4.Size = new Size(1327, 350);
            dWisata4.TabIndex = 3;
            // 
            // dWisata5
            // 
            dWisata5.Dock = DockStyle.Top;
            dWisata5.Location = new Point(3, 1427);
            dWisata5.Name = "dWisata5";
            dWisata5.Size = new Size(1327, 350);
            dWisata5.TabIndex = 4;
            // 
            // DetailWisata
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetailWisata";
            Text = "DetailWisata";
            Load += DetailWisata_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DWisata dWisata1;
        private DWisata dWisata2;
        private DWisata dWisata3;
        private DWisata dWisata4;
        private DWisata dWisata5;
    }
}