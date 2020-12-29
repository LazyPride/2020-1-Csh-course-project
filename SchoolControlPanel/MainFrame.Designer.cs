namespace SchoolControlPanel
{
    partial class MainFrame
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
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_add_teacher = new System.Windows.Forms.Button();
            this.button_add_subject = new System.Windows.Forms.Button();
            this.button_add_student_group = new System.Windows.Forms.Button();
            this.button_add_student = new System.Windows.Forms.Button();
            this.button_add_mark = new System.Windows.Forms.Button();
            this.button_add_learning_program = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add_classroom = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "TestConnection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(208, 21);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 524);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_add_teacher);
            this.panel1.Controls.Add(this.button_add_subject);
            this.panel1.Controls.Add(this.button_add_student_group);
            this.panel1.Controls.Add(this.button_add_student);
            this.panel1.Controls.Add(this.button_add_mark);
            this.panel1.Controls.Add(this.button_add_learning_program);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_add_classroom);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 505);
            this.panel1.TabIndex = 0;
            // 
            // button_add_teacher
            // 
            this.button_add_teacher.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_add_teacher.Location = new System.Drawing.Point(25, 241);
            this.button_add_teacher.Margin = new System.Windows.Forms.Padding(5);
            this.button_add_teacher.Name = "button_add_teacher";
            this.button_add_teacher.Size = new System.Drawing.Size(232, 41);
            this.button_add_teacher.TabIndex = 8;
            this.button_add_teacher.Text = "Add teacher";
            this.button_add_teacher.UseVisualStyleBackColor = true;
            this.button_add_teacher.Click += new System.EventHandler(this.button_add_teacher_Click);
            // 
            // button_add_subject
            // 
            this.button_add_subject.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_add_subject.Location = new System.Drawing.Point(25, 292);
            this.button_add_subject.Margin = new System.Windows.Forms.Padding(5);
            this.button_add_subject.Name = "button_add_subject";
            this.button_add_subject.Size = new System.Drawing.Size(232, 41);
            this.button_add_subject.TabIndex = 7;
            this.button_add_subject.Text = "Add subject";
            this.button_add_subject.UseVisualStyleBackColor = true;
            this.button_add_subject.Click += new System.EventHandler(this.button_add_subject_Click);
            // 
            // button_add_student_group
            // 
            this.button_add_student_group.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_add_student_group.Location = new System.Drawing.Point(25, 190);
            this.button_add_student_group.Margin = new System.Windows.Forms.Padding(5);
            this.button_add_student_group.Name = "button_add_student_group";
            this.button_add_student_group.Size = new System.Drawing.Size(232, 41);
            this.button_add_student_group.TabIndex = 6;
            this.button_add_student_group.Text = "Add student group";
            this.button_add_student_group.UseVisualStyleBackColor = true;
            // 
            // button_add_student
            // 
            this.button_add_student.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_add_student.Location = new System.Drawing.Point(25, 139);
            this.button_add_student.Margin = new System.Windows.Forms.Padding(5);
            this.button_add_student.Name = "button_add_student";
            this.button_add_student.Size = new System.Drawing.Size(232, 41);
            this.button_add_student.TabIndex = 5;
            this.button_add_student.Text = "Add student";
            this.button_add_student.UseVisualStyleBackColor = true;
            // 
            // button_add_mark
            // 
            this.button_add_mark.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_add_mark.Location = new System.Drawing.Point(25, 88);
            this.button_add_mark.Margin = new System.Windows.Forms.Padding(5);
            this.button_add_mark.Name = "button_add_mark";
            this.button_add_mark.Size = new System.Drawing.Size(232, 41);
            this.button_add_mark.TabIndex = 4;
            this.button_add_mark.Text = "Add mark";
            this.button_add_mark.UseVisualStyleBackColor = true;
            // 
            // button_add_learning_program
            // 
            this.button_add_learning_program.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_add_learning_program.Location = new System.Drawing.Point(25, 343);
            this.button_add_learning_program.Margin = new System.Windows.Forms.Padding(5);
            this.button_add_learning_program.Name = "button_add_learning_program";
            this.button_add_learning_program.Size = new System.Drawing.Size(232, 41);
            this.button_add_learning_program.TabIndex = 3;
            this.button_add_learning_program.Text = "Add learning program";
            this.button_add_learning_program.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Creation panel";
            // 
            // button_add_classroom
            // 
            this.button_add_classroom.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_add_classroom.Location = new System.Drawing.Point(25, 394);
            this.button_add_classroom.Margin = new System.Windows.Forms.Padding(5);
            this.button_add_classroom.Name = "button_add_classroom";
            this.button_add_classroom.Size = new System.Drawing.Size(232, 41);
            this.button_add_classroom.TabIndex = 0;
            this.button_add_classroom.Text = "Add classroom";
            this.button_add_classroom.UseVisualStyleBackColor = true;
            this.button_add_classroom.Click += new System.EventHandler(this.button_add_classroom_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 575);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainFrame";
            this.Text = "School Control Panel";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_add_classroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add_teacher;
        private System.Windows.Forms.Button button_add_subject;
        private System.Windows.Forms.Button button_add_student_group;
        private System.Windows.Forms.Button button_add_student;
        private System.Windows.Forms.Button button_add_learning_program;
        private System.Windows.Forms.Button button_add_mark;
    }
}

