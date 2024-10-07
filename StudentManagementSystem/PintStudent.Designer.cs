namespace StudentManagementSystem
{
    partial class PintStudentForm
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
            this.btn_print = new System.Windows.Forms.Button();
            this.radioBox_female = new System.Windows.Forms.RadioButton();
            this.dataGrid_Student = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBox_male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton_allGender = new System.Windows.Forms.RadioButton();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_StudentInCourse = new System.Windows.Forms.Label();
            this.btn_showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Student)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(780, 43);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(109, 33);
            this.btn_print.TabIndex = 14;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // radioBox_female
            // 
            this.radioBox_female.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBox_female.AutoSize = true;
            this.radioBox_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBox_female.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radioBox_female.Location = new System.Drawing.Point(222, 47);
            this.radioBox_female.Name = "radioBox_female";
            this.radioBox_female.Size = new System.Drawing.Size(86, 24);
            this.radioBox_female.TabIndex = 8;
            this.radioBox_female.Text = "Female";
            this.radioBox_female.UseVisualStyleBackColor = true;
            this.radioBox_female.CheckedChanged += new System.EventHandler(this.radioBox_female_CheckedChanged);
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
            this.dataGrid_Student.Location = new System.Drawing.Point(27, 95);
            this.dataGrid_Student.Name = "dataGrid_Student";
            this.dataGrid_Student.RowTemplate.Height = 50;
            this.dataGrid_Student.Size = new System.Drawing.Size(862, 419);
            this.dataGrid_Student.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Print Student List";
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
            this.panel1.TabIndex = 4;
            // 
            // radioBox_male
            // 
            this.radioBox_male.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBox_male.AutoSize = true;
            this.radioBox_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBox_male.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radioBox_male.Location = new System.Drawing.Point(151, 47);
            this.radioBox_male.Name = "radioBox_male";
            this.radioBox_male.Size = new System.Drawing.Size(65, 24);
            this.radioBox_male.TabIndex = 7;
            this.radioBox_male.Text = "Male";
            this.radioBox_male.UseVisualStyleBackColor = true;
            this.radioBox_male.CheckedChanged += new System.EventHandler(this.radioBox_male_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(15, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_print);
            this.panel2.Controls.Add(this.radioButton_allGender);
            this.panel2.Controls.Add(this.radioBox_female);
            this.panel2.Controls.Add(this.radioBox_male);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 97);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(27, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(862, 8);
            this.panel3.TabIndex = 0;
            // 
            // radioButton_allGender
            // 
            this.radioButton_allGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_allGender.AutoSize = true;
            this.radioButton_allGender.Checked = true;
            this.radioButton_allGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_allGender.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radioButton_allGender.Location = new System.Drawing.Point(98, 47);
            this.radioButton_allGender.Name = "radioButton_allGender";
            this.radioButton_allGender.Size = new System.Drawing.Size(47, 24);
            this.radioButton_allGender.TabIndex = 8;
            this.radioButton_allGender.TabStop = true;
            this.radioButton_allGender.Text = "All";
            this.radioButton_allGender.UseVisualStyleBackColor = true;
            this.radioButton_allGender.CheckedChanged += new System.EventHandler(this.radioButton_allGender_CheckedChanged);
            // 
            // comboBox_Course
            // 
            this.comboBox_Course.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Course.FormattingEnabled = true;
            this.comboBox_Course.Location = new System.Drawing.Point(157, 62);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(219, 28);
            this.comboBox_Course.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Course :";
            // 
            // lbl_StudentInCourse
            // 
            this.lbl_StudentInCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_StudentInCourse.AutoSize = true;
            this.lbl_StudentInCourse.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_StudentInCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentInCourse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_StudentInCourse.Location = new System.Drawing.Point(382, 65);
            this.lbl_StudentInCourse.Name = "lbl_StudentInCourse";
            this.lbl_StudentInCourse.Size = new System.Drawing.Size(219, 20);
            this.lbl_StudentInCourse.TabIndex = 0;
            this.lbl_StudentInCourse.Text = "Total Student In This Course :";
            // 
            // btn_showAll
            // 
            this.btn_showAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_showAll.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_showAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showAll.ForeColor = System.Drawing.Color.White;
            this.btn_showAll.Location = new System.Drawing.Point(780, 57);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(109, 33);
            this.btn_showAll.TabIndex = 7;
            this.btn_showAll.Text = "Show All";
            this.btn_showAll.UseVisualStyleBackColor = false;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // PintStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 611);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.comboBox_Course);
            this.Controls.Add(this.dataGrid_Student);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_StudentInCourse);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PintStudentForm";
            this.Text = "PintStudentForm";
            this.Load += new System.EventHandler(this.PintStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Student)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.RadioButton radioBox_female;
        private System.Windows.Forms.DataGridView dataGrid_Student;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBox_male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton_allGender;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_StudentInCourse;
        private System.Windows.Forms.Button btn_showAll;
    }
}