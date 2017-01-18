namespace FinalProjectJohnPietrangelo
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.studentsBtn = new System.Windows.Forms.Button();
            this.schedulesBtn = new System.Windows.Forms.Button();
            this.coursesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.navScrnHdrLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentsBtn
            // 
            this.studentsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.studentsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.studentsBtn.FlatAppearance.BorderSize = 3;
            this.studentsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.studentsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.studentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentsBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsBtn.Location = new System.Drawing.Point(308, 111);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(145, 45);
            this.studentsBtn.TabIndex = 1;
            this.studentsBtn.Text = "&Students";
            this.studentsBtn.UseVisualStyleBackColor = false;
            this.studentsBtn.Click += new System.EventHandler(this.studentsBtn_Click);
            // 
            // schedulesBtn
            // 
            this.schedulesBtn.BackColor = System.Drawing.Color.MistyRose;
            this.schedulesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.schedulesBtn.FlatAppearance.BorderSize = 3;
            this.schedulesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.schedulesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.schedulesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.schedulesBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulesBtn.Location = new System.Drawing.Point(308, 266);
            this.schedulesBtn.Name = "schedulesBtn";
            this.schedulesBtn.Size = new System.Drawing.Size(145, 45);
            this.schedulesBtn.TabIndex = 3;
            this.schedulesBtn.Text = "S&chedules";
            this.schedulesBtn.UseVisualStyleBackColor = false;
            this.schedulesBtn.Click += new System.EventHandler(this.schedulesBtn_Click);
            // 
            // coursesBtn
            // 
            this.coursesBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.coursesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.coursesBtn.FlatAppearance.BorderSize = 3;
            this.coursesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.coursesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.coursesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coursesBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesBtn.Location = new System.Drawing.Point(308, 185);
            this.coursesBtn.Name = "coursesBtn";
            this.coursesBtn.Size = new System.Drawing.Size(145, 45);
            this.coursesBtn.TabIndex = 2;
            this.coursesBtn.Text = "&Courses";
            this.coursesBtn.UseVisualStyleBackColor = false;
            this.coursesBtn.Click += new System.EventHandler(this.coursesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.exitBtn.FlatAppearance.BorderSize = 2;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(705, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(52, 33);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // navScrnHdrLbl
            // 
            this.navScrnHdrLbl.BackColor = System.Drawing.Color.Transparent;
            this.navScrnHdrLbl.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navScrnHdrLbl.ForeColor = System.Drawing.Color.Black;
            this.navScrnHdrLbl.Location = new System.Drawing.Point(128, 31);
            this.navScrnHdrLbl.Name = "navScrnHdrLbl";
            this.navScrnHdrLbl.Size = new System.Drawing.Size(502, 47);
            this.navScrnHdrLbl.TabIndex = 0;
            this.navScrnHdrLbl.Text = "Registration Navigation Page";
            this.navScrnHdrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 361);
            this.Controls.Add(this.navScrnHdrLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.coursesBtn);
            this.Controls.Add(this.schedulesBtn);
            this.Controls.Add(this.studentsBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentsBtn;
        private System.Windows.Forms.Button schedulesBtn;
        private System.Windows.Forms.Button coursesBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label navScrnHdrLbl;
    }
}

