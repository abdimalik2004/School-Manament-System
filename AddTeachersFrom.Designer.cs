namespace School_Manament_System
{
    partial class AddTeachersFrom
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timage = new System.Windows.Forms.PictureBox();
            this.tdeletebtn = new System.Windows.Forms.Button();
            this.tclearbtn = new System.Windows.Forms.Button();
            this.tupdatebtn = new System.Windows.Forms.Button();
            this.taddbtn = new System.Windows.Forms.Button();
            this.timportbtn = new System.Windows.Forms.Button();
            this.tstatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.taddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tgender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tdatagrid = new System.Windows.Forms.DataGridView();
            this.teacherssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet3 = new School_Manament_System.schoolDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.teacherssTableAdapter = new School_Manament_System.schoolDataSet3TableAdapters.teacherssTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersaddresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tdeletebtn);
            this.panel2.Controls.Add(this.tclearbtn);
            this.panel2.Controls.Add(this.tupdatebtn);
            this.panel2.Controls.Add(this.taddbtn);
            this.panel2.Controls.Add(this.timportbtn);
            this.panel2.Controls.Add(this.tstatus);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.taddress);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tgender);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 410);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 327);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.timage);
            this.panel3.Location = new System.Drawing.Point(982, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 125);
            this.panel3.TabIndex = 18;
            // 
            // timage
            // 
            this.timage.BackColor = System.Drawing.Color.Gray;
            this.timage.Location = new System.Drawing.Point(0, 0);
            this.timage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timage.Name = "timage";
            this.timage.Size = new System.Drawing.Size(117, 125);
            this.timage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.timage.TabIndex = 12;
            this.timage.TabStop = false;
            // 
            // tdeletebtn
            // 
            this.tdeletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.tdeletebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdeletebtn.ForeColor = System.Drawing.Color.White;
            this.tdeletebtn.Location = new System.Drawing.Point(816, 262);
            this.tdeletebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tdeletebtn.Name = "tdeletebtn";
            this.tdeletebtn.Size = new System.Drawing.Size(118, 60);
            this.tdeletebtn.TabIndex = 17;
            this.tdeletebtn.Text = "Delete";
            this.tdeletebtn.UseVisualStyleBackColor = false;
            this.tdeletebtn.Click += new System.EventHandler(this.tdeletebtn_Click);
            // 
            // tclearbtn
            // 
            this.tclearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.tclearbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclearbtn.ForeColor = System.Drawing.Color.White;
            this.tclearbtn.Location = new System.Drawing.Point(628, 260);
            this.tclearbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tclearbtn.Name = "tclearbtn";
            this.tclearbtn.Size = new System.Drawing.Size(118, 60);
            this.tclearbtn.TabIndex = 16;
            this.tclearbtn.Text = "Clear";
            this.tclearbtn.UseVisualStyleBackColor = false;
            // 
            // tupdatebtn
            // 
            this.tupdatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.tupdatebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tupdatebtn.ForeColor = System.Drawing.Color.White;
            this.tupdatebtn.Location = new System.Drawing.Point(440, 262);
            this.tupdatebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tupdatebtn.Name = "tupdatebtn";
            this.tupdatebtn.Size = new System.Drawing.Size(118, 60);
            this.tupdatebtn.TabIndex = 15;
            this.tupdatebtn.Text = "Update";
            this.tupdatebtn.UseVisualStyleBackColor = false;
            this.tupdatebtn.Click += new System.EventHandler(this.tupdatebtn_Click);
            // 
            // taddbtn
            // 
            this.taddbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.taddbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taddbtn.ForeColor = System.Drawing.Color.White;
            this.taddbtn.Location = new System.Drawing.Point(216, 260);
            this.taddbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.taddbtn.Name = "taddbtn";
            this.taddbtn.Size = new System.Drawing.Size(118, 60);
            this.taddbtn.TabIndex = 14;
            this.taddbtn.Text = "Add";
            this.taddbtn.UseVisualStyleBackColor = false;
            this.taddbtn.Click += new System.EventHandler(this.taddbtn_Click);
            // 
            // timportbtn
            // 
            this.timportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.timportbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timportbtn.ForeColor = System.Drawing.Color.White;
            this.timportbtn.Location = new System.Drawing.Point(978, 185);
            this.timportbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timportbtn.Name = "timportbtn";
            this.timportbtn.Size = new System.Drawing.Size(128, 46);
            this.timportbtn.TabIndex = 13;
            this.timportbtn.Text = "Import";
            this.timportbtn.UseVisualStyleBackColor = false;
            this.timportbtn.Click += new System.EventHandler(this.timportbtn_Click);
            // 
            // tstatus
            // 
            this.tstatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstatus.FormattingEnabled = true;
            this.tstatus.Items.AddRange(new object[] {
            "Active",
            "Not Active"});
            this.tstatus.Location = new System.Drawing.Point(561, 145);
            this.tstatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tstatus.Name = "tstatus";
            this.tstatus.Size = new System.Drawing.Size(254, 37);
            this.tstatus.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status :";
            // 
            // taddress
            // 
            this.taddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taddress.Location = new System.Drawing.Point(561, 57);
            this.taddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.taddress.Multiline = true;
            this.taddress.Name = "taddress";
            this.taddress.Size = new System.Drawing.Size(254, 61);
            this.taddress.TabIndex = 7;
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
            // tgender
            // 
            this.tgender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgender.FormattingEnabled = true;
            this.tgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.tgender.Location = new System.Drawing.Point(158, 145);
            this.tgender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tgender.Name = "tgender";
            this.tgender.Size = new System.Drawing.Size(250, 37);
            this.tgender.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender :";
            // 
            // tname
            // 
            this.tname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tname.Location = new System.Drawing.Point(158, 57);
            this.tname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tname.Multiline = true;
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(250, 44);
            this.tname.TabIndex = 3;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tdatagrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 336);
            this.panel1.TabIndex = 2;
            // 
            // tdatagrid
            // 
            this.tdatagrid.AutoGenerateColumns = false;
            this.tdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.teachersnameDataGridViewTextBoxColumn,
            this.teachersgenderDataGridViewTextBoxColumn,
            this.teachersaddresDataGridViewTextBoxColumn,
            this.teachersstatusDataGridViewTextBoxColumn});
            this.tdatagrid.DataSource = this.teacherssBindingSource;
            this.tdatagrid.Location = new System.Drawing.Point(-3, 35);
            this.tdatagrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tdatagrid.Name = "tdatagrid";
            this.tdatagrid.RowHeadersWidth = 62;
            this.tdatagrid.Size = new System.Drawing.Size(1206, 279);
            this.tdatagrid.TabIndex = 1;
            this.tdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tdatagrid_CellContentClick);
            this.tdatagrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tdatagrid_CellMouseClick);
            // 
            // teacherssBindingSource
            // 
            this.teacherssBindingSource.DataMember = "teacherss";
            this.teacherssBindingSource.DataSource = this.schoolDataSet3;
            // 
            // schoolDataSet3
            // 
            this.schoolDataSet3.DataSetName = "schoolDataSet3";
            this.schoolDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher\'s Data";
            // 
            // teacherssTableAdapter
            // 
            this.teacherssTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1215, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(538, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "School Managment System | Add Teacher Form";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(2, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = "⬅️\r\n";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 62;
            // 
            // teachersnameDataGridViewTextBoxColumn
            // 
            this.teachersnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teachersnameDataGridViewTextBoxColumn.DataPropertyName = "teachers_name";
            this.teachersnameDataGridViewTextBoxColumn.HeaderText = "teachers_name";
            this.teachersnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teachersnameDataGridViewTextBoxColumn.Name = "teachersnameDataGridViewTextBoxColumn";
            // 
            // teachersgenderDataGridViewTextBoxColumn
            // 
            this.teachersgenderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teachersgenderDataGridViewTextBoxColumn.DataPropertyName = "teachers_gender";
            this.teachersgenderDataGridViewTextBoxColumn.HeaderText = "teachers_gender";
            this.teachersgenderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teachersgenderDataGridViewTextBoxColumn.Name = "teachersgenderDataGridViewTextBoxColumn";
            // 
            // teachersaddresDataGridViewTextBoxColumn
            // 
            this.teachersaddresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teachersaddresDataGridViewTextBoxColumn.DataPropertyName = "teachers_addres";
            this.teachersaddresDataGridViewTextBoxColumn.HeaderText = "teachers_addres";
            this.teachersaddresDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teachersaddresDataGridViewTextBoxColumn.Name = "teachersaddresDataGridViewTextBoxColumn";
            // 
            // teachersstatusDataGridViewTextBoxColumn
            // 
            this.teachersstatusDataGridViewTextBoxColumn.DataPropertyName = "teachers_status";
            this.teachersstatusDataGridViewTextBoxColumn.HeaderText = "teachers_status";
            this.teachersstatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teachersstatusDataGridViewTextBoxColumn.Name = "teachersstatusDataGridViewTextBoxColumn";
            this.teachersstatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // AddTeachersFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 740);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTeachersFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTeachersFrom";
            this.Load += new System.EventHandler(this.AddTeachersFrom_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox timage;
        private System.Windows.Forms.Button tdeletebtn;
        private System.Windows.Forms.Button tclearbtn;
        private System.Windows.Forms.Button tupdatebtn;
        private System.Windows.Forms.Button taddbtn;
        private System.Windows.Forms.Button timportbtn;
        private System.Windows.Forms.ComboBox tstatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox taddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tgender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tdatagrid;
        private System.Windows.Forms.Label label1;
        private schoolDataSet3 schoolDataSet3;
        private System.Windows.Forms.BindingSource teacherssBindingSource;
        private schoolDataSet3TableAdapters.teacherssTableAdapter teacherssTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersaddresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersstatusDataGridViewTextBoxColumn;
    }
}