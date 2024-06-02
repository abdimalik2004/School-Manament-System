namespace School_Manament_System
{
    partial class AddStudentsForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sdatagrid = new System.Windows.Forms.DataGridView();
            this.studdentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet2 = new School_Manament_System.schoolDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.simage = new System.Windows.Forms.PictureBox();
            this.sdeletebtn = new System.Windows.Forms.Button();
            this.sclearbtn = new System.Windows.Forms.Button();
            this.supdatebtn = new System.Windows.Forms.Button();
            this.saddbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ssection = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sgrade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sgender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.schoolDataSet = new School_Manament_System.schoolDataSet();
            this.studdentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studdentsTableAdapter = new School_Manament_System.schoolDataSetTableAdapters.studdentsTableAdapter();
            this.schoolDataSet1 = new School_Manament_System.schoolDataSet1();
            this.studdentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studdentsTableAdapter1 = new School_Manament_System.schoolDataSet1TableAdapters.studdentsTableAdapter();
            this.studdentsTableAdapter2 = new School_Manament_System.schoolDataSet2TableAdapters.studdentsTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsaddresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsgradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentssectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsimageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studdentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studdentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studdentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sdatagrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 336);
            this.panel1.TabIndex = 0;
            // 
            // sdatagrid
            // 
            this.sdatagrid.AutoGenerateColumns = false;
            this.sdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.studentsnameDataGridViewTextBoxColumn,
            this.studentsgenderDataGridViewTextBoxColumn,
            this.studentsaddresDataGridViewTextBoxColumn,
            this.studentsgradeDataGridViewTextBoxColumn,
            this.studentssectionDataGridViewTextBoxColumn,
            this.studentsimageDataGridViewTextBoxColumn});
            this.sdatagrid.DataSource = this.studdentsBindingSource2;
            this.sdatagrid.Location = new System.Drawing.Point(-3, 35);
            this.sdatagrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sdatagrid.Name = "sdatagrid";
            this.sdatagrid.RowHeadersWidth = 62;
            this.sdatagrid.Size = new System.Drawing.Size(1206, 279);
            this.sdatagrid.TabIndex = 1;
            this.sdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sdatagrid_CellContentClick);
            this.sdatagrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sdatagrid_CellMouseClick);
            // 
            // studdentsBindingSource2
            // 
            this.studdentsBindingSource2.DataMember = "studdents";
            this.studdentsBindingSource2.DataSource = this.schoolDataSet2;
            // 
            // schoolDataSet2
            // 
            this.schoolDataSet2.DataSetName = "schoolDataSet2";
            this.schoolDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.sdeletebtn);
            this.panel2.Controls.Add(this.sclearbtn);
            this.panel2.Controls.Add(this.supdatebtn);
            this.panel2.Controls.Add(this.saddbtn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.ssection);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.sgrade);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.saddress);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.sgender);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.sname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 414);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 327);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.simage);
            this.panel3.Location = new System.Drawing.Point(1061, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 125);
            this.panel3.TabIndex = 18;
            // 
            // simage
            // 
            this.simage.BackColor = System.Drawing.Color.Gray;
            this.simage.Location = new System.Drawing.Point(0, 0);
            this.simage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.simage.Name = "simage";
            this.simage.Size = new System.Drawing.Size(117, 125);
            this.simage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.simage.TabIndex = 12;
            this.simage.TabStop = false;
            this.simage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sdeletebtn
            // 
            this.sdeletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.sdeletebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdeletebtn.ForeColor = System.Drawing.Color.White;
            this.sdeletebtn.Location = new System.Drawing.Point(816, 262);
            this.sdeletebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sdeletebtn.Name = "sdeletebtn";
            this.sdeletebtn.Size = new System.Drawing.Size(118, 60);
            this.sdeletebtn.TabIndex = 17;
            this.sdeletebtn.Text = "Delete";
            this.sdeletebtn.UseVisualStyleBackColor = false;
            this.sdeletebtn.Click += new System.EventHandler(this.sdeletebtn_Click);
            // 
            // sclearbtn
            // 
            this.sclearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.sclearbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sclearbtn.ForeColor = System.Drawing.Color.White;
            this.sclearbtn.Location = new System.Drawing.Point(628, 260);
            this.sclearbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sclearbtn.Name = "sclearbtn";
            this.sclearbtn.Size = new System.Drawing.Size(118, 60);
            this.sclearbtn.TabIndex = 16;
            this.sclearbtn.Text = "Clear";
            this.sclearbtn.UseVisualStyleBackColor = false;
            // 
            // supdatebtn
            // 
            this.supdatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.supdatebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supdatebtn.ForeColor = System.Drawing.Color.White;
            this.supdatebtn.Location = new System.Drawing.Point(440, 262);
            this.supdatebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supdatebtn.Name = "supdatebtn";
            this.supdatebtn.Size = new System.Drawing.Size(118, 60);
            this.supdatebtn.TabIndex = 15;
            this.supdatebtn.Text = "Update";
            this.supdatebtn.UseVisualStyleBackColor = false;
            this.supdatebtn.Click += new System.EventHandler(this.supdatebtn_Click);
            // 
            // saddbtn
            // 
            this.saddbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.saddbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saddbtn.ForeColor = System.Drawing.Color.White;
            this.saddbtn.Location = new System.Drawing.Point(216, 260);
            this.saddbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saddbtn.Name = "saddbtn";
            this.saddbtn.Size = new System.Drawing.Size(118, 60);
            this.saddbtn.TabIndex = 14;
            this.saddbtn.Text = "Add";
            this.saddbtn.UseVisualStyleBackColor = false;
            this.saddbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1061, 243);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ssection
            // 
            this.ssection.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssection.FormattingEnabled = true;
            this.ssection.Items.AddRange(new object[] {
            "Fee",
            "not fee"});
            this.ssection.Location = new System.Drawing.Point(946, 57);
            this.ssection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ssection.Name = "ssection";
            this.ssection.Size = new System.Drawing.Size(254, 37);
            this.ssection.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(828, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Section :";
            // 
            // sgrade
            // 
            this.sgrade.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgrade.FormattingEnabled = true;
            this.sgrade.Items.AddRange(new object[] {
            "Primary",
            "secondary"});
            this.sgrade.Location = new System.Drawing.Point(561, 142);
            this.sgrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sgrade.Name = "sgrade";
            this.sgrade.Size = new System.Drawing.Size(254, 37);
            this.sgrade.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Grade :";
            // 
            // saddress
            // 
            this.saddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saddress.Location = new System.Drawing.Point(561, 57);
            this.saddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saddress.Multiline = true;
            this.saddress.Name = "saddress";
            this.saddress.Size = new System.Drawing.Size(254, 61);
            this.saddress.TabIndex = 7;
            this.saddress.TextChanged += new System.EventHandler(this.saddress_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address :";
            // 
            // sgender
            // 
            this.sgender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgender.FormattingEnabled = true;
            this.sgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sgender.Location = new System.Drawing.Point(158, 145);
            this.sgender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sgender.Name = "sgender";
            this.sgender.Size = new System.Drawing.Size(250, 37);
            this.sgender.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender :";
            // 
            // sname
            // 
            this.sname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sname.Location = new System.Drawing.Point(158, 57);
            this.sname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sname.Multiline = true;
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(250, 44);
            this.sname.TabIndex = 3;
            this.sname.TextChanged += new System.EventHandler(this.sname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name :";
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "schoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studdentsBindingSource
            // 
            this.studdentsBindingSource.DataMember = "studdents";
            this.studdentsBindingSource.DataSource = this.schoolDataSet;
            // 
            // studdentsTableAdapter
            // 
            this.studdentsTableAdapter.ClearBeforeFill = true;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "schoolDataSet1";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studdentsBindingSource1
            // 
            this.studdentsBindingSource1.DataMember = "studdents";
            this.studdentsBindingSource1.DataSource = this.schoolDataSet1;
            // 
            // studdentsTableAdapter1
            // 
            this.studdentsTableAdapter1.ClearBeforeFill = true;
            // 
            // studdentsTableAdapter2
            // 
            this.studdentsTableAdapter2.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1201, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(537, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "School Managment System | Add Student Form";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(1, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 39);
            this.label9.TabIndex = 7;
            this.label9.Text = "⬅️\r\n";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 62;
            // 
            // studentsnameDataGridViewTextBoxColumn
            // 
            this.studentsnameDataGridViewTextBoxColumn.DataPropertyName = "students_name";
            this.studentsnameDataGridViewTextBoxColumn.HeaderText = "students_name";
            this.studentsnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentsnameDataGridViewTextBoxColumn.Name = "studentsnameDataGridViewTextBoxColumn";
            this.studentsnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentsgenderDataGridViewTextBoxColumn
            // 
            this.studentsgenderDataGridViewTextBoxColumn.DataPropertyName = "students_gender";
            this.studentsgenderDataGridViewTextBoxColumn.HeaderText = "students_gender";
            this.studentsgenderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentsgenderDataGridViewTextBoxColumn.Name = "studentsgenderDataGridViewTextBoxColumn";
            this.studentsgenderDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentsaddresDataGridViewTextBoxColumn
            // 
            this.studentsaddresDataGridViewTextBoxColumn.DataPropertyName = "students_addres";
            this.studentsaddresDataGridViewTextBoxColumn.HeaderText = "students_addres";
            this.studentsaddresDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentsaddresDataGridViewTextBoxColumn.Name = "studentsaddresDataGridViewTextBoxColumn";
            this.studentsaddresDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentsgradeDataGridViewTextBoxColumn
            // 
            this.studentsgradeDataGridViewTextBoxColumn.DataPropertyName = "students_grade";
            this.studentsgradeDataGridViewTextBoxColumn.HeaderText = "students_grade";
            this.studentsgradeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentsgradeDataGridViewTextBoxColumn.Name = "studentsgradeDataGridViewTextBoxColumn";
            this.studentsgradeDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentssectionDataGridViewTextBoxColumn
            // 
            this.studentssectionDataGridViewTextBoxColumn.DataPropertyName = "students_section";
            this.studentssectionDataGridViewTextBoxColumn.HeaderText = "students_section";
            this.studentssectionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentssectionDataGridViewTextBoxColumn.Name = "studentssectionDataGridViewTextBoxColumn";
            this.studentssectionDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentsimageDataGridViewTextBoxColumn
            // 
            this.studentsimageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentsimageDataGridViewTextBoxColumn.DataPropertyName = "students_image";
            this.studentsimageDataGridViewTextBoxColumn.HeaderText = "students_image";
            this.studentsimageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentsimageDataGridViewTextBoxColumn.Name = "studentsimageDataGridViewTextBoxColumn";
            // 
            // AddStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 755);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentsForm";
            this.Load += new System.EventHandler(this.AddStudentsForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddStudentsForm_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studdentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.simage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studdentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studdentsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView sdatagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sgrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox saddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sgender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox simage;
        private System.Windows.Forms.ComboBox ssection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sdeletebtn;
        private System.Windows.Forms.Button sclearbtn;
        private System.Windows.Forms.Button supdatebtn;
        private System.Windows.Forms.Button saddbtn;
        private System.Windows.Forms.Panel panel3;
        private schoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource studdentsBindingSource;
        private schoolDataSetTableAdapters.studdentsTableAdapter studdentsTableAdapter;
        private schoolDataSet1 schoolDataSet1;
        private System.Windows.Forms.BindingSource studdentsBindingSource1;
        private schoolDataSet1TableAdapters.studdentsTableAdapter studdentsTableAdapter1;
        private schoolDataSet2 schoolDataSet2;
        private System.Windows.Forms.BindingSource studdentsBindingSource2;
        private schoolDataSet2TableAdapters.studdentsTableAdapter studdentsTableAdapter2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsaddresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsgradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentssectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsimageDataGridViewTextBoxColumn;
    }
}