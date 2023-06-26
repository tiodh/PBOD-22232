namespace frontendpbo
{
    partial class DetailEvent
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
            buttonJudul = new Button();
            dataGridView1Search = new DataGridView();
            label1 = new Label();
            textBox6Search = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1Search).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonJudul
            // 
            buttonJudul.BackColor = Color.Thistle;
            buttonJudul.Dock = DockStyle.Top;
            buttonJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonJudul.ForeColor = SystemColors.Desktop;
            buttonJudul.Location = new Point(0, 0);
            buttonJudul.Margin = new Padding(2);
            buttonJudul.Name = "buttonJudul";
            buttonJudul.Size = new Size(1073, 52);
            buttonJudul.TabIndex = 0;
            buttonJudul.Text = "EVENT ACARA";
            buttonJudul.UseVisualStyleBackColor = false;
            // 
            // dataGridView1Search
            // 
            dataGridView1Search.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1Search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1Search.Dock = DockStyle.Fill;
            dataGridView1Search.Location = new Point(0, 112);
            dataGridView1Search.Margin = new Padding(2);
            dataGridView1Search.Name = "dataGridView1Search";
            dataGridView1Search.RowHeadersWidth = 62;
            dataGridView1Search.RowTemplate.Height = 33;
            dataGridView1Search.Size = new Size(1073, 389);
            dataGridView1Search.TabIndex = 1;
            dataGridView1Search.CellClick += dataGridView1_CellClick;
            dataGridView1Search.CellContentClick += dataGridView1Search_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Search";
            label1.Click += label1_Click;
            // 
            // textBox6Search
            // 
            textBox6Search.Location = new Point(67, 18);
            textBox6Search.Margin = new Padding(3, 2, 3, 2);
            textBox6Search.Name = "textBox6Search";
            textBox6Search.Size = new Size(171, 23);
            textBox6Search.TabIndex = 0;
            textBox6Search.Text = "masukkan kata kunci";
            textBox6Search.Click += textBox6Search_Click;
            textBox6Search.TextChanged += textBox6Search_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1Search);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonJudul);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(70, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 501);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox6Search);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(1073, 60);
            panel2.TabIndex = 1;
            // 
            // DetailEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 591);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "DetailEvent";
            Padding = new Padding(70, 20, 70, 70);
            Text = "DetailEvent";
            ((System.ComponentModel.ISupportInitialize)dataGridView1Search).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonJudul;
        private DataGridView dataGridView1Search;
        private TextBox textBox6Search;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}