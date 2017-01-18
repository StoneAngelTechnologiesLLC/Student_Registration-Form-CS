namespace FinalProjectJohnPietrangelo
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.curUnitListLbl = new System.Windows.Forms.Label();
            this.curStartListLbl = new System.Windows.Forms.Label();
            this.curDaysListLbl = new System.Windows.Forms.Label();
            this.curSeatsListLbl = new System.Windows.Forms.Label();
            this.curTitleListLbl = new System.Windows.Forms.Label();
            this.curCourseNumListLbl = new System.Windows.Forms.Label();
            this.curSubjectListLbl = new System.Windows.Forms.Label();
            this.totalCreditsLbl = new System.Windows.Forms.Label();
            this.totalCreditsTxBx = new System.Windows.Forms.TextBox();
            this.AddCourseLbl = new System.Windows.Forms.Label();
            this.currentCourseLbl = new System.Windows.Forms.Label();
            this.studentIDLbl = new System.Windows.Forms.Label();
            this.removeCourseLbl = new System.Windows.Forms.Label();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.unitsLbl = new System.Windows.Forms.Label();
            this.stratTimeLbl = new System.Windows.Forms.Label();
            this.daysLbl = new System.Windows.Forms.Label();
            this.seatsLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.courseNumlbl = new System.Windows.Forms.Label();
            this.sublbl = new System.Windows.Forms.Label();
            this.studentAddCourseLstBx = new System.Windows.Forms.ListBox();
            this.StudentAddCourse2LstBx = new System.Windows.Forms.ListBox();
            this.studentIDCmbBx = new System.Windows.Forms.ComboBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.editCourseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.mainMenuBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mainMenuBtn.FlatAppearance.BorderSize = 3;
            this.mainMenuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.mainMenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(667, 13);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(169, 41);
            this.mainMenuBtn.TabIndex = 0;
            this.mainMenuBtn.Text = "&Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = false;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // curUnitListLbl
            // 
            this.curUnitListLbl.BackColor = System.Drawing.Color.Transparent;
            this.curUnitListLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curUnitListLbl.Location = new System.Drawing.Point(186, 307);
            this.curUnitListLbl.Name = "curUnitListLbl";
            this.curUnitListLbl.Size = new System.Drawing.Size(45, 19);
            this.curUnitListLbl.TabIndex = 0;
            this.curUnitListLbl.Text = "Units";
            this.curUnitListLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // curStartListLbl
            // 
            this.curStartListLbl.BackColor = System.Drawing.Color.Transparent;
            this.curStartListLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curStartListLbl.Location = new System.Drawing.Point(392, 307);
            this.curStartListLbl.Name = "curStartListLbl";
            this.curStartListLbl.Size = new System.Drawing.Size(95, 19);
            this.curStartListLbl.TabIndex = 0;
            this.curStartListLbl.Text = "Start Time";
            this.curStartListLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // curDaysListLbl
            // 
            this.curDaysListLbl.BackColor = System.Drawing.Color.Transparent;
            this.curDaysListLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curDaysListLbl.Location = new System.Drawing.Point(522, 307);
            this.curDaysListLbl.Name = "curDaysListLbl";
            this.curDaysListLbl.Size = new System.Drawing.Size(45, 19);
            this.curDaysListLbl.TabIndex = 0;
            this.curDaysListLbl.Text = "Days";
            this.curDaysListLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // curSeatsListLbl
            // 
            this.curSeatsListLbl.BackColor = System.Drawing.Color.Transparent;
            this.curSeatsListLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curSeatsListLbl.Location = new System.Drawing.Point(587, 307);
            this.curSeatsListLbl.Name = "curSeatsListLbl";
            this.curSeatsListLbl.Size = new System.Drawing.Size(50, 19);
            this.curSeatsListLbl.TabIndex = 0;
            this.curSeatsListLbl.Text = "Seats";
            this.curSeatsListLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // curTitleListLbl
            // 
            this.curTitleListLbl.BackColor = System.Drawing.Color.Transparent;
            this.curTitleListLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTitleListLbl.Location = new System.Drawing.Point(292, 307);
            this.curTitleListLbl.Name = "curTitleListLbl";
            this.curTitleListLbl.Size = new System.Drawing.Size(44, 19);
            this.curTitleListLbl.TabIndex = 0;
            this.curTitleListLbl.Text = "Title";
            this.curTitleListLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // curCourseNumListLbl
            // 
            this.curCourseNumListLbl.BackColor = System.Drawing.Color.Transparent;
            this.curCourseNumListLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curCourseNumListLbl.Location = new System.Drawing.Point(90, 307);
            this.curCourseNumListLbl.Name = "curCourseNumListLbl";
            this.curCourseNumListLbl.Size = new System.Drawing.Size(53, 19);
            this.curCourseNumListLbl.TabIndex = 0;
            this.curCourseNumListLbl.Text = "Course#";
            this.curCourseNumListLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // curSubjectListLbl
            // 
            this.curSubjectListLbl.BackColor = System.Drawing.Color.Transparent;
            this.curSubjectListLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curSubjectListLbl.Location = new System.Drawing.Point(12, 307);
            this.curSubjectListLbl.Name = "curSubjectListLbl";
            this.curSubjectListLbl.Size = new System.Drawing.Size(47, 19);
            this.curSubjectListLbl.TabIndex = 0;
            this.curSubjectListLbl.Text = "Subject";
            this.curSubjectListLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCreditsLbl
            // 
            this.totalCreditsLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalCreditsLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCreditsLbl.Location = new System.Drawing.Point(712, 298);
            this.totalCreditsLbl.Name = "totalCreditsLbl";
            this.totalCreditsLbl.Size = new System.Drawing.Size(117, 28);
            this.totalCreditsLbl.TabIndex = 0;
            this.totalCreditsLbl.Text = "Total Credits";
            this.totalCreditsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalCreditsTxBx
            // 
            this.totalCreditsTxBx.BackColor = System.Drawing.SystemColors.Info;
            this.totalCreditsTxBx.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCreditsTxBx.Location = new System.Drawing.Point(738, 347);
            this.totalCreditsTxBx.Multiline = true;
            this.totalCreditsTxBx.Name = "totalCreditsTxBx";
            this.totalCreditsTxBx.ReadOnly = true;
            this.totalCreditsTxBx.Size = new System.Drawing.Size(61, 51);
            this.totalCreditsTxBx.TabIndex = 0;
            this.totalCreditsTxBx.TabStop = false;
            this.totalCreditsTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddCourseLbl
            // 
            this.AddCourseLbl.BackColor = System.Drawing.Color.Transparent;
            this.AddCourseLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCourseLbl.Location = new System.Drawing.Point(182, 77);
            this.AddCourseLbl.Name = "AddCourseLbl";
            this.AddCourseLbl.Size = new System.Drawing.Size(479, 21);
            this.AddCourseLbl.TabIndex = 0;
            this.AddCourseLbl.Text = "To Add A Scheduled Course: Select Course then Click \"Add Course\"";
            this.AddCourseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentCourseLbl
            // 
            this.currentCourseLbl.BackColor = System.Drawing.Color.Transparent;
            this.currentCourseLbl.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCourseLbl.Location = new System.Drawing.Point(289, 257);
            this.currentCourseLbl.Name = "currentCourseLbl";
            this.currentCourseLbl.Size = new System.Drawing.Size(205, 38);
            this.currentCourseLbl.TabIndex = 0;
            this.currentCourseLbl.Text = "Current Schedule";
            this.currentCourseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentIDLbl
            // 
            this.studentIDLbl.BackColor = System.Drawing.Color.Transparent;
            this.studentIDLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDLbl.Location = new System.Drawing.Point(18, 9);
            this.studentIDLbl.Name = "studentIDLbl";
            this.studentIDLbl.Size = new System.Drawing.Size(155, 19);
            this.studentIDLbl.TabIndex = 0;
            this.studentIDLbl.Text = "SELECT STUDENT ";
            // 
            // removeCourseLbl
            // 
            this.removeCourseLbl.BackColor = System.Drawing.Color.Transparent;
            this.removeCourseLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCourseLbl.Location = new System.Drawing.Point(185, 77);
            this.removeCourseLbl.Name = "removeCourseLbl";
            this.removeCourseLbl.Size = new System.Drawing.Size(487, 21);
            this.removeCourseLbl.TabIndex = 4;
            this.removeCourseLbl.Text = "To  Remove A Scheduled Course: Select Course and Click \"Remove\" ";
            this.removeCourseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.addCourseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addCourseBtn.FlatAppearance.BorderSize = 3;
            this.addCourseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.addCourseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCourseBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseBtn.Location = new System.Drawing.Point(693, 137);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(143, 34);
            this.addCourseBtn.TabIndex = 1;
            this.addCourseBtn.Text = "&Add Course";
            this.addCourseBtn.UseVisualStyleBackColor = false;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // unitsLbl
            // 
            this.unitsLbl.BackColor = System.Drawing.Color.Transparent;
            this.unitsLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsLbl.Location = new System.Drawing.Point(186, 115);
            this.unitsLbl.Name = "unitsLbl";
            this.unitsLbl.Size = new System.Drawing.Size(45, 19);
            this.unitsLbl.TabIndex = 11;
            this.unitsLbl.Text = "Units";
            this.unitsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stratTimeLbl
            // 
            this.stratTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.stratTimeLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stratTimeLbl.Location = new System.Drawing.Point(392, 115);
            this.stratTimeLbl.Name = "stratTimeLbl";
            this.stratTimeLbl.Size = new System.Drawing.Size(95, 19);
            this.stratTimeLbl.TabIndex = 12;
            this.stratTimeLbl.Text = "Start Time";
            this.stratTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // daysLbl
            // 
            this.daysLbl.BackColor = System.Drawing.Color.Transparent;
            this.daysLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLbl.Location = new System.Drawing.Point(522, 115);
            this.daysLbl.Name = "daysLbl";
            this.daysLbl.Size = new System.Drawing.Size(45, 19);
            this.daysLbl.TabIndex = 13;
            this.daysLbl.Text = "Days";
            this.daysLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // seatsLbl
            // 
            this.seatsLbl.BackColor = System.Drawing.Color.Transparent;
            this.seatsLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatsLbl.Location = new System.Drawing.Point(587, 115);
            this.seatsLbl.Name = "seatsLbl";
            this.seatsLbl.Size = new System.Drawing.Size(50, 19);
            this.seatsLbl.TabIndex = 14;
            this.seatsLbl.Text = "Seats";
            this.seatsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(292, 115);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(44, 19);
            this.titleLbl.TabIndex = 15;
            this.titleLbl.Text = "Title";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // courseNumlbl
            // 
            this.courseNumlbl.BackColor = System.Drawing.Color.Transparent;
            this.courseNumlbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNumlbl.Location = new System.Drawing.Point(90, 115);
            this.courseNumlbl.Name = "courseNumlbl";
            this.courseNumlbl.Size = new System.Drawing.Size(53, 19);
            this.courseNumlbl.TabIndex = 16;
            this.courseNumlbl.Text = "Course#";
            this.courseNumlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sublbl
            // 
            this.sublbl.BackColor = System.Drawing.Color.Transparent;
            this.sublbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sublbl.Location = new System.Drawing.Point(12, 115);
            this.sublbl.Name = "sublbl";
            this.sublbl.Size = new System.Drawing.Size(47, 19);
            this.sublbl.TabIndex = 17;
            this.sublbl.Text = "Subject";
            this.sublbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // studentAddCourseLstBx
            // 
            this.studentAddCourseLstBx.BackColor = System.Drawing.SystemColors.Info;
            this.studentAddCourseLstBx.FormattingEnabled = true;
            this.studentAddCourseLstBx.Location = new System.Drawing.Point(10, 137);
            this.studentAddCourseLstBx.Name = "studentAddCourseLstBx";
            this.studentAddCourseLstBx.ScrollAlwaysVisible = true;
            this.studentAddCourseLstBx.Size = new System.Drawing.Size(651, 95);
            this.studentAddCourseLstBx.TabIndex = 2;
            this.studentAddCourseLstBx.SelectedIndexChanged += new System.EventHandler(this.StudentAddCourseLstBx_SelectedIndexChanged);
            // 
            // StudentAddCourse2LstBx
            // 
            this.StudentAddCourse2LstBx.BackColor = System.Drawing.SystemColors.Info;
            this.StudentAddCourse2LstBx.FormattingEnabled = true;
            this.StudentAddCourse2LstBx.Location = new System.Drawing.Point(10, 329);
            this.StudentAddCourse2LstBx.Name = "StudentAddCourse2LstBx";
            this.StudentAddCourse2LstBx.ScrollAlwaysVisible = true;
            this.StudentAddCourse2LstBx.Size = new System.Drawing.Size(651, 95);
            this.StudentAddCourse2LstBx.TabIndex = 3;
            // 
            // studentIDCmbBx
            // 
            this.studentIDCmbBx.FormattingEnabled = true;
            this.studentIDCmbBx.Location = new System.Drawing.Point(10, 31);
            this.studentIDCmbBx.Name = "studentIDCmbBx";
            this.studentIDCmbBx.Size = new System.Drawing.Size(178, 21);
            this.studentIDCmbBx.TabIndex = 0;
            this.studentIDCmbBx.Text = "Click Arrow ->";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetBtn.FlatAppearance.BorderSize = 3;
            this.resetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.resetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(693, 257);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(142, 36);
            this.resetBtn.TabIndex = 115;
            this.resetBtn.Text = "&Return";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // editCourseBtn
            // 
            this.editCourseBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.editCourseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editCourseBtn.FlatAppearance.BorderSize = 3;
            this.editCourseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.editCourseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.editCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCourseBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCourseBtn.Location = new System.Drawing.Point(693, 198);
            this.editCourseBtn.Name = "editCourseBtn";
            this.editCourseBtn.Size = new System.Drawing.Size(143, 34);
            this.editCourseBtn.TabIndex = 116;
            this.editCourseBtn.Text = "&Edit Course";
            this.editCourseBtn.UseVisualStyleBackColor = false;
            this.editCourseBtn.Click += new System.EventHandler(this.editCourseBtn_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = global::FinalProjectJohnPietrangelo.Properties.Resources.asu_watermark_lg_dk_0_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 449);
            this.Controls.Add(this.editCourseBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.studentIDCmbBx);
            this.Controls.Add(this.StudentAddCourse2LstBx);
            this.Controls.Add(this.studentAddCourseLstBx);
            this.Controls.Add(this.unitsLbl);
            this.Controls.Add(this.stratTimeLbl);
            this.Controls.Add(this.daysLbl);
            this.Controls.Add(this.seatsLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.courseNumlbl);
            this.Controls.Add(this.sublbl);
            this.Controls.Add(this.addCourseBtn);
            this.Controls.Add(this.removeCourseLbl);
            this.Controls.Add(this.studentIDLbl);
            this.Controls.Add(this.currentCourseLbl);
            this.Controls.Add(this.AddCourseLbl);
            this.Controls.Add(this.totalCreditsTxBx);
            this.Controls.Add(this.totalCreditsLbl);
            this.Controls.Add(this.curUnitListLbl);
            this.Controls.Add(this.curStartListLbl);
            this.Controls.Add(this.curDaysListLbl);
            this.Controls.Add(this.curSeatsListLbl);
            this.Controls.Add(this.curTitleListLbl);
            this.Controls.Add(this.curCourseNumListLbl);
            this.Controls.Add(this.curSubjectListLbl);
            this.Controls.Add(this.mainMenuBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Label curUnitListLbl;
        private System.Windows.Forms.Label curStartListLbl;
        private System.Windows.Forms.Label curDaysListLbl;
        private System.Windows.Forms.Label curSeatsListLbl;
        private System.Windows.Forms.Label curTitleListLbl;
        private System.Windows.Forms.Label curCourseNumListLbl;
        private System.Windows.Forms.Label curSubjectListLbl;
        private System.Windows.Forms.Label totalCreditsLbl;
        private System.Windows.Forms.TextBox totalCreditsTxBx;
        private System.Windows.Forms.Label AddCourseLbl;
        private System.Windows.Forms.Label currentCourseLbl;
        private System.Windows.Forms.Label studentIDLbl;
        private System.Windows.Forms.Label removeCourseLbl;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.Label unitsLbl;
        private System.Windows.Forms.Label stratTimeLbl;
        private System.Windows.Forms.Label daysLbl;
        private System.Windows.Forms.Label seatsLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label courseNumlbl;
        private System.Windows.Forms.Label sublbl;
        private System.Windows.Forms.ListBox studentAddCourseLstBx;
        private System.Windows.Forms.ListBox StudentAddCourse2LstBx;
        private System.Windows.Forms.ComboBox studentIDCmbBx;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button editCourseBtn;
    }
}