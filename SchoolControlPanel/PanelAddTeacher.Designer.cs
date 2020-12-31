namespace SchoolControlPanel
{
    partial class PanelAddTeacher
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
            this.text_box_teacher_first_name = new System.Windows.Forms.TextBox();
            this.PanelAddTeacherErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_teacher_first_name = new System.Windows.Forms.Label();
            this.label_teacher_last_name = new System.Windows.Forms.Label();
            this.text_box_teacher_last_name = new System.Windows.Forms.TextBox();
            this.label_teacher_third_name = new System.Windows.Forms.Label();
            this.text_box_teacher_third_name = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedlistbox_subjects = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PanelAddTeacherErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // text_box_teacher_first_name
            // 
            this.text_box_teacher_first_name.Location = new System.Drawing.Point(206, 29);
            this.text_box_teacher_first_name.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_teacher_first_name.Name = "text_box_teacher_first_name";
            this.text_box_teacher_first_name.Size = new System.Drawing.Size(282, 31);
            this.text_box_teacher_first_name.TabIndex = 0;
            // 
            // PanelAddTeacherErrorProvider
            // 
            this.PanelAddTeacherErrorProvider.ContainerControl = this;
            // 
            // label_teacher_first_name
            // 
            this.label_teacher_first_name.AutoSize = true;
            this.label_teacher_first_name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_teacher_first_name.Location = new System.Drawing.Point(17, 34);
            this.label_teacher_first_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_teacher_first_name.Name = "label_teacher_first_name";
            this.label_teacher_first_name.Size = new System.Drawing.Size(174, 26);
            this.label_teacher_first_name.TabIndex = 1;
            this.label_teacher_first_name.Text = "Teacher first name:";
            // 
            // label_teacher_last_name
            // 
            this.label_teacher_last_name.AutoSize = true;
            this.label_teacher_last_name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_teacher_last_name.Location = new System.Drawing.Point(17, 75);
            this.label_teacher_last_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_teacher_last_name.Name = "label_teacher_last_name";
            this.label_teacher_last_name.Size = new System.Drawing.Size(171, 26);
            this.label_teacher_last_name.TabIndex = 2;
            this.label_teacher_last_name.Text = "Teacher last name:";
            // 
            // text_box_teacher_last_name
            // 
            this.text_box_teacher_last_name.Location = new System.Drawing.Point(206, 70);
            this.text_box_teacher_last_name.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_teacher_last_name.Name = "text_box_teacher_last_name";
            this.text_box_teacher_last_name.Size = new System.Drawing.Size(282, 31);
            this.text_box_teacher_last_name.TabIndex = 3;
            // 
            // label_teacher_third_name
            // 
            this.label_teacher_third_name.AutoSize = true;
            this.label_teacher_third_name.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_teacher_third_name.Location = new System.Drawing.Point(14, 116);
            this.label_teacher_third_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_teacher_third_name.Name = "label_teacher_third_name";
            this.label_teacher_third_name.Size = new System.Drawing.Size(182, 26);
            this.label_teacher_third_name.TabIndex = 4;
            this.label_teacher_third_name.Text = "Teacher third name:";
            // 
            // text_box_teacher_third_name
            // 
            this.text_box_teacher_third_name.Location = new System.Drawing.Point(206, 111);
            this.text_box_teacher_third_name.Margin = new System.Windows.Forms.Padding(5);
            this.text_box_teacher_third_name.Name = "text_box_teacher_third_name";
            this.text_box_teacher_third_name.Size = new System.Drawing.Size(282, 31);
            this.text_box_teacher_third_name.TabIndex = 5;
            // 
            // button_confirm
            // 
            this.button_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_confirm.Location = new System.Drawing.Point(127, 347);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(100, 40);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "Add";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(243, 347);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 40);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Close";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose subjects to teach:";
            // 
            // checkedlistbox_subjects
            // 
            this.checkedlistbox_subjects.CheckOnClick = true;
            this.checkedlistbox_subjects.FormattingEnabled = true;
            this.checkedlistbox_subjects.Location = new System.Drawing.Point(22, 190);
            this.checkedlistbox_subjects.Name = "checkedlistbox_subjects";
            this.checkedlistbox_subjects.Size = new System.Drawing.Size(466, 134);
            this.checkedlistbox_subjects.TabIndex = 9;
            // 
            // PanelAddTeacher
            // 
            this.AcceptButton = this.button_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(509, 399);
            this.Controls.Add(this.checkedlistbox_subjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.text_box_teacher_third_name);
            this.Controls.Add(this.label_teacher_third_name);
            this.Controls.Add(this.text_box_teacher_last_name);
            this.Controls.Add(this.label_teacher_last_name);
            this.Controls.Add(this.label_teacher_first_name);
            this.Controls.Add(this.text_box_teacher_first_name);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PanelAddTeacher";
            this.Text = "Add Teacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelAddTeacher_FormClosing);
            this.Load += new System.EventHandler(this.PanelAddTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelAddTeacherErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_box_teacher_first_name;
        private System.Windows.Forms.Label label_teacher_first_name;
        private System.Windows.Forms.Label label_teacher_last_name;
        private System.Windows.Forms.TextBox text_box_teacher_last_name;
        private System.Windows.Forms.Label label_teacher_third_name;
        private System.Windows.Forms.TextBox text_box_teacher_third_name;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ErrorProvider PanelAddTeacherErrorProvider;
        private ValidatorText validatorText_first_name;
        private ValidatorText validatorText_last_name;
        private System.Windows.Forms.CheckedListBox checkedlistbox_subjects;
        private System.Windows.Forms.Label label1;
    }
}