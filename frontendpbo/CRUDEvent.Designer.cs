namespace frontendpbo
{
    partial class FormEditEvent
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
            btnClose = new Button();
            labelEditEvent = new Label();
            btnDeleteEvent = new Button();
            btnUpdateEvent = new Button();
            btnCreateEvent = new Button();
            tvIdWisata = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            tbNamaEvent = new TextBox();
            tbIdEvent = new TextBox();
            labelIdWisata = new Label();
            labelTglEvent = new Label();
            labelDeskripsiEvent = new Label();
            labelNamaEvent = new Label();
            labelIdEvent = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.WhiteSmoke;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(743, 31);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 31);
            btnClose.TabIndex = 31;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // labelEditEvent
            // 
            labelEditEvent.AutoSize = true;
            labelEditEvent.BackColor = Color.Transparent;
            labelEditEvent.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEditEvent.Location = new Point(46, 23);
            labelEditEvent.Name = "labelEditEvent";
            labelEditEvent.Size = new Size(111, 30);
            labelEditEvent.TabIndex = 30;
            labelEditEvent.Text = "Edit Event";
            // 
            // btnDeleteEvent
            // 
            btnDeleteEvent.BackColor = Color.Red;
            btnDeleteEvent.FlatAppearance.BorderSize = 0;
            btnDeleteEvent.FlatStyle = FlatStyle.Flat;
            btnDeleteEvent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteEvent.ForeColor = Color.White;
            btnDeleteEvent.Location = new Point(708, 324);
            btnDeleteEvent.Name = "btnDeleteEvent";
            btnDeleteEvent.Size = new Size(75, 23);
            btnDeleteEvent.TabIndex = 29;
            btnDeleteEvent.Text = "Delete";
            btnDeleteEvent.UseVisualStyleBackColor = false;
            btnDeleteEvent.Click += btnDeleteEvent_Click;
            // 
            // btnUpdateEvent
            // 
            btnUpdateEvent.BackColor = Color.Orange;
            btnUpdateEvent.FlatAppearance.BorderSize = 0;
            btnUpdateEvent.FlatStyle = FlatStyle.Flat;
            btnUpdateEvent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateEvent.ForeColor = Color.White;
            btnUpdateEvent.Location = new Point(607, 324);
            btnUpdateEvent.Name = "btnUpdateEvent";
            btnUpdateEvent.Size = new Size(75, 23);
            btnUpdateEvent.TabIndex = 28;
            btnUpdateEvent.Text = "Update";
            btnUpdateEvent.UseVisualStyleBackColor = false;
            btnUpdateEvent.Click += btnUpdateEvent_Click;
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.BackColor = Color.Green;
            btnCreateEvent.FlatAppearance.BorderSize = 0;
            btnCreateEvent.FlatStyle = FlatStyle.Flat;
            btnCreateEvent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateEvent.ForeColor = Color.White;
            btnCreateEvent.Location = new Point(506, 325);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(75, 23);
            btnCreateEvent.TabIndex = 27;
            btnCreateEvent.Text = "Create";
            btnCreateEvent.UseVisualStyleBackColor = false;
            btnCreateEvent.Click += btnCreateEvent_Click;
            // 
            // tvIdWisata
            // 
            tvIdWisata.Location = new Point(215, 449);
            tvIdWisata.Name = "tvIdWisata";
            tvIdWisata.Size = new Size(200, 23);
            tvIdWisata.TabIndex = 26;
            tvIdWisata.Text = "0";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(215, 418);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 387);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 24;
            // 
            // tbNamaEvent
            // 
            tbNamaEvent.Location = new Point(215, 356);
            tbNamaEvent.Name = "tbNamaEvent";
            tbNamaEvent.Size = new Size(200, 23);
            tbNamaEvent.TabIndex = 23;
            // 
            // tbIdEvent
            // 
            tbIdEvent.Location = new Point(215, 325);
            tbIdEvent.Name = "tbIdEvent";
            tbIdEvent.Size = new Size(200, 23);
            tbIdEvent.TabIndex = 22;
            tbIdEvent.Text = "0";
            // 
            // labelIdWisata
            // 
            labelIdWisata.AutoSize = true;
            labelIdWisata.BackColor = Color.Transparent;
            labelIdWisata.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdWisata.Location = new Point(46, 451);
            labelIdWisata.Name = "labelIdWisata";
            labelIdWisata.Size = new Size(77, 21);
            labelIdWisata.TabIndex = 21;
            labelIdWisata.Text = "Id Wisata";
            // 
            // labelTglEvent
            // 
            labelTglEvent.AutoSize = true;
            labelTglEvent.BackColor = Color.Transparent;
            labelTglEvent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTglEvent.Location = new Point(46, 420);
            labelTglEvent.Name = "labelTglEvent";
            labelTglEvent.Size = new Size(110, 21);
            labelTglEvent.TabIndex = 20;
            labelTglEvent.Text = "Tanggal Event";
            // 
            // labelDeskripsiEvent
            // 
            labelDeskripsiEvent.AutoSize = true;
            labelDeskripsiEvent.BackColor = Color.Transparent;
            labelDeskripsiEvent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeskripsiEvent.Location = new Point(46, 389);
            labelDeskripsiEvent.Name = "labelDeskripsiEvent";
            labelDeskripsiEvent.Size = new Size(120, 21);
            labelDeskripsiEvent.TabIndex = 19;
            labelDeskripsiEvent.Text = "Deskripsi Event";
            // 
            // labelNamaEvent
            // 
            labelNamaEvent.AutoSize = true;
            labelNamaEvent.BackColor = Color.Transparent;
            labelNamaEvent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNamaEvent.Location = new Point(46, 358);
            labelNamaEvent.Name = "labelNamaEvent";
            labelNamaEvent.Size = new Size(96, 21);
            labelNamaEvent.TabIndex = 18;
            labelNamaEvent.Text = "Nama Event";
            // 
            // labelIdEvent
            // 
            labelIdEvent.AutoSize = true;
            labelIdEvent.BackColor = Color.Transparent;
            labelIdEvent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdEvent.Location = new Point(46, 327);
            labelIdEvent.Name = "labelIdEvent";
            labelIdEvent.Size = new Size(70, 21);
            labelIdEvent.TabIndex = 17;
            labelIdEvent.Text = "ID Event";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(772, 220);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormEditEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 494);
            Controls.Add(btnClose);
            Controls.Add(labelEditEvent);
            Controls.Add(btnDeleteEvent);
            Controls.Add(btnUpdateEvent);
            Controls.Add(btnCreateEvent);
            Controls.Add(tvIdWisata);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(tbNamaEvent);
            Controls.Add(tbIdEvent);
            Controls.Add(labelIdWisata);
            Controls.Add(labelTglEvent);
            Controls.Add(labelDeskripsiEvent);
            Controls.Add(labelNamaEvent);
            Controls.Add(labelIdEvent);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditEvent";
            Text = "FormEditEvent";
            Load += FormEditEvent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label labelEditEvent;
        private Button btnDeleteEvent;
        private Button btnUpdateEvent;
        private Button btnCreateEvent;
        private TextBox tvIdWisata;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox tbNamaEvent;
        private TextBox tbIdEvent;
        private Label labelIdWisata;
        private Label labelTglEvent;
        private Label labelDeskripsiEvent;
        private Label labelNamaEvent;
        private Label labelIdEvent;
        private DataGridView dataGridView1;
    }
}