namespace StudentManagementSystem
{
    partial class ManageStudentCourseForm
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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Score = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Update_Score = new System.Windows.Forms.Button();
            this.btn_Update_Semester = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox_Semester = new System.Windows.Forms.ComboBox();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add_Course = new System.Windows.Forms.Button();
            this.btn_Delete_Course = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGrid_Course = new System.Windows.Forms.DataGridView();
            this.dataGrid_Student = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_StudentName = new System.Windows.Forms.Label();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.BackColor = System.Drawing.Color.Orange;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(786, 203);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(109, 33);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(19, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 8);
            this.panel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(19, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Select Semester:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(68, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Add Score:";
            // 
            // txt_Score
            // 
            this.txt_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Score.Location = new System.Drawing.Point(172, 149);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(147, 26);
            this.txt_Score.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Update_Score);
            this.panel2.Controls.Add(this.btn_Update_Semester);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.comboBox_Semester);
            this.panel2.Controls.Add(this.comboBox_Course);
            this.panel2.Controls.Add(this.txt_Score);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Controls.Add(this.btn_Add_Course);
            this.panel2.Controls.Add(this.btn_Delete_Course);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 248);
            this.panel2.TabIndex = 10;
            // 
            // btn_Update_Score
            // 
            this.btn_Update_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Update_Score.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Update_Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_Score.ForeColor = System.Drawing.Color.White;
            this.btn_Update_Score.Location = new System.Drawing.Point(485, 149);
            this.btn_Update_Score.Name = "btn_Update_Score";
            this.btn_Update_Score.Size = new System.Drawing.Size(109, 33);
            this.btn_Update_Score.TabIndex = 25;
            this.btn_Update_Score.Text = "Update";
            this.btn_Update_Score.UseVisualStyleBackColor = false;
            this.btn_Update_Score.Click += new System.EventHandler(this.btn_Update_Score_Click_1);
            // 
            // btn_Update_Semester
            // 
            this.btn_Update_Semester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Update_Semester.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Update_Semester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_Semester.ForeColor = System.Drawing.Color.White;
            this.btn_Update_Semester.Location = new System.Drawing.Point(485, 30);
            this.btn_Update_Semester.Name = "btn_Update_Semester";
            this.btn_Update_Semester.Size = new System.Drawing.Size(109, 33);
            this.btn_Update_Semester.TabIndex = 24;
            this.btn_Update_Semester.Text = "Update";
            this.btn_Update_Semester.UseVisualStyleBackColor = false;
            this.btn_Update_Semester.Click += new System.EventHandler(this.btn_Update_Semester_Click_1);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(19, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(875, 4);
            this.panel5.TabIndex = 23;
            // 
            // comboBox_Semester
            // 
            this.comboBox_Semester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_Semester.FormattingEnabled = true;
            this.comboBox_Semester.Location = new System.Drawing.Point(172, 27);
            this.comboBox_Semester.Name = "comboBox_Semester";
            this.comboBox_Semester.Size = new System.Drawing.Size(278, 28);
            this.comboBox_Semester.TabIndex = 22;
            // 
            // comboBox_Course
            // 
            this.comboBox_Course.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_Course.FormattingEnabled = true;
            this.comboBox_Course.Location = new System.Drawing.Point(172, 70);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(278, 28);
            this.comboBox_Course.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(39, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select Course:";
            // 
            // btn_Add_Course
            // 
            this.btn_Add_Course.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Add_Course.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Add_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Course.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Course.Location = new System.Drawing.Point(485, 65);
            this.btn_Add_Course.Name = "btn_Add_Course";
            this.btn_Add_Course.Size = new System.Drawing.Size(109, 33);
            this.btn_Add_Course.TabIndex = 14;
            this.btn_Add_Course.Text = "Add";
            this.btn_Add_Course.UseVisualStyleBackColor = false;
            this.btn_Add_Course.Click += new System.EventHandler(this.btn_Add_Course_Click);
            // 
            // btn_Delete_Course
            // 
            this.btn_Delete_Course.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Delete_Course.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Delete_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_Course.ForeColor = System.Drawing.Color.White;
            this.btn_Delete_Course.Location = new System.Drawing.Point(624, 65);
            this.btn_Delete_Course.Name = "btn_Delete_Course";
            this.btn_Delete_Course.Size = new System.Drawing.Size(109, 33);
            this.btn_Delete_Course.TabIndex = 14;
            this.btn_Delete_Course.Text = "Delete";
            this.btn_Delete_Course.UseVisualStyleBackColor = false;
            this.btn_Delete_Course.Click += new System.EventHandler(this.btn_Delete_Course_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(257, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(337, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Manage Student Course and Score";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 52);
            this.panel1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGrid_Course);
            this.panel4.Controls.Add(this.dataGrid_Student);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(0, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(914, 269);
            this.panel4.TabIndex = 14;
            // 
            // dataGrid_Course
            // 
            this.dataGrid_Course.AllowUserToDeleteRows = false;
            this.dataGrid_Course.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Course.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_Course.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Course.Location = new System.Drawing.Point(464, 27);
            this.dataGrid_Course.Name = "dataGrid_Course";
            this.dataGrid_Course.ReadOnly = true;
            this.dataGrid_Course.RowTemplate.Height = 50;
            this.dataGrid_Course.Size = new System.Drawing.Size(431, 242);
            this.dataGrid_Course.TabIndex = 20;
            this.dataGrid_Course.Click += new System.EventHandler(this.dataGrid_Course_Click);
            // 
            // dataGrid_Student
            // 
            this.dataGrid_Student.AllowUserToAddRows = false;
            this.dataGrid_Student.AllowUserToDeleteRows = false;
            this.dataGrid_Student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Student.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_Student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Student.Location = new System.Drawing.Point(19, 27);
            this.dataGrid_Student.Name = "dataGrid_Student";
            this.dataGrid_Student.ReadOnly = true;
            this.dataGrid_Student.RowTemplate.Height = 50;
            this.dataGrid_Student.Size = new System.Drawing.Size(431, 242);
            this.dataGrid_Student.TabIndex = 11;
            this.dataGrid_Student.Click += new System.EventHandler(this.dataGrid_Student_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(465, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Course List:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(15, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Student List:";
            // 
            // lbl_StudentName
            // 
            this.lbl_StudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_StudentName.AutoSize = true;
            this.lbl_StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentName.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_StudentName.Location = new System.Drawing.Point(481, 67);
            this.lbl_StudentName.Name = "lbl_StudentName";
            this.lbl_StudentName.Size = new System.Drawing.Size(0, 24);
            this.lbl_StudentName.TabIndex = 12;
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowAll.ForeColor = System.Drawing.Color.White;
            this.btn_ShowAll.Location = new System.Drawing.Point(19, 58);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(109, 33);
            this.btn_ShowAll.TabIndex = 17;
            this.btn_ShowAll.Text = "Show All";
            this.btn_ShowAll.UseVisualStyleBackColor = false;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(333, 58);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(109, 33);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(172, 61);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(147, 26);
            this.txt_Search.TabIndex = 15;
            // 
            // ManageStudentCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 611);
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lbl_StudentName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageStudentCourseForm";
            this.Text = "ManageStudentCourseForm";
            this.Load += new System.EventHandler(this.ManageStudentCourseForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Score;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_StudentName;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.Button btn_Add_Course;
        private System.Windows.Forms.Button btn_Delete_Course;
        private System.Windows.Forms.ComboBox comboBox_Semester;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGrid_Course;
        private System.Windows.Forms.DataGridView dataGrid_Student;
        private System.Windows.Forms.Button btn_Update_Semester;
        private System.Windows.Forms.Button btn_Update_Score;
    }
}