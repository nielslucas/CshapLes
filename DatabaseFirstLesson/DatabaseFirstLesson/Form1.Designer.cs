namespace DatabaseFirstLesson
{
    partial class Form1
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
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.tbTeacher = new System.Windows.Forms.TextBox();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.AddCourse = new System.Windows.Forms.TextBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCourses
            // 
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.Location = new System.Drawing.Point(13, 13);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.Size = new System.Drawing.Size(120, 290);
            this.lbCourses.TabIndex = 0;
            this.lbCourses.SelectedIndexChanged += new System.EventHandler(this.lbCourses_SelectedIndexChanged);
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(140, 52);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(120, 251);
            this.lbStudents.TabIndex = 1;
            this.lbStudents.SelectedIndexChanged += new System.EventHandler(this.lbStudents_SelectedIndexChanged);
            // 
            // tbTeacher
            // 
            this.tbTeacher.Location = new System.Drawing.Point(140, 13);
            this.tbTeacher.Name = "tbTeacher";
            this.tbTeacher.Size = new System.Drawing.Size(120, 20);
            this.tbTeacher.TabIndex = 2;
            this.tbTeacher.TextChanged += new System.EventHandler(this.tbTeacher_TextChanged);
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(267, 279);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(119, 23);
            this.AddCourseButton.TabIndex = 4;
            this.AddCourseButton.Text = "AddCourseButton";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // AddCourse
            // 
            this.AddCourse.Location = new System.Drawing.Point(267, 253);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(119, 20);
            this.AddCourse.TabIndex = 5;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(140, 319);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(120, 20);
            this.searchText.TabIndex = 6;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(140, 346);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(120, 23);
            this.searchbutton.TabIndex = 7;
            this.searchbutton.Text = "button1";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 622);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.AddCourse);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.tbTeacher);
            this.Controls.Add(this.lbStudents);
            this.Controls.Add(this.lbCourses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCourses;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.TextBox tbTeacher;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.TextBox AddCourse;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchbutton;
    }
}

