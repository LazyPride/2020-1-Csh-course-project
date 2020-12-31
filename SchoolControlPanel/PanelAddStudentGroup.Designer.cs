namespace SchoolControlPanel
{
    partial class PanelAddStudentGroup
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
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textbox_year_of_creation = new System.Windows.Forms.TextBox();
            this.textbox_group_name = new System.Windows.Forms.TextBox();
            this.label_year_of_creation = new System.Windows.Forms.Label();
            this.laber_group_name = new System.Windows.Forms.Label();
            this.listbox_classroom_teacher = new System.Windows.Forms.ListBox();
            this.label_choose_teacher = new System.Windows.Forms.Label();
            this.label_classroom = new System.Windows.Forms.Label();
            this.listbox_classroom = new System.Windows.Forms.ListBox();
            this.checkedLilistbox_students = new System.Windows.Forms.CheckedListBox();
            this.label_students = new System.Windows.Forms.Label();
            this.label_learning_program = new System.Windows.Forms.Label();
            this.listbox_learning_program = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button_confirm
            // 
            this.button_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_confirm.Location = new System.Drawing.Point(145, 865);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(100, 40);
            this.button_confirm.TabIndex = 9;
            this.button_confirm.Text = "Add";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(251, 865);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 40);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Close";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textbox_year_of_creation
            // 
            this.textbox_year_of_creation.Location = new System.Drawing.Point(170, 79);
            this.textbox_year_of_creation.MaxLength = 4;
            this.textbox_year_of_creation.Name = "textbox_year_of_creation";
            this.textbox_year_of_creation.Size = new System.Drawing.Size(63, 31);
            this.textbox_year_of_creation.TabIndex = 15;
            // 
            // textbox_group_name
            // 
            this.textbox_group_name.Location = new System.Drawing.Point(170, 42);
            this.textbox_group_name.MaxLength = 65536;
            this.textbox_group_name.Name = "textbox_group_name";
            this.textbox_group_name.Size = new System.Drawing.Size(292, 31);
            this.textbox_group_name.TabIndex = 14;
            // 
            // label_year_of_creation
            // 
            this.label_year_of_creation.AutoSize = true;
            this.label_year_of_creation.Location = new System.Drawing.Point(28, 82);
            this.label_year_of_creation.Name = "label_year_of_creation";
            this.label_year_of_creation.Size = new System.Drawing.Size(136, 23);
            this.label_year_of_creation.TabIndex = 12;
            this.label_year_of_creation.Text = "Year of creation:";
            // 
            // laber_group_name
            // 
            this.laber_group_name.AutoSize = true;
            this.laber_group_name.Location = new System.Drawing.Point(28, 50);
            this.laber_group_name.Name = "laber_group_name";
            this.laber_group_name.Size = new System.Drawing.Size(111, 23);
            this.laber_group_name.TabIndex = 11;
            this.laber_group_name.Text = "Group name:";
            // 
            // listbox_classroom_teacher
            // 
            this.listbox_classroom_teacher.FormattingEnabled = true;
            this.listbox_classroom_teacher.ItemHeight = 23;
            this.listbox_classroom_teacher.Location = new System.Drawing.Point(32, 173);
            this.listbox_classroom_teacher.Name = "listbox_classroom_teacher";
            this.listbox_classroom_teacher.Size = new System.Drawing.Size(442, 119);
            this.listbox_classroom_teacher.TabIndex = 16;
            // 
            // label_choose_teacher
            // 
            this.label_choose_teacher.AutoSize = true;
            this.label_choose_teacher.Location = new System.Drawing.Point(28, 147);
            this.label_choose_teacher.Name = "label_choose_teacher";
            this.label_choose_teacher.Size = new System.Drawing.Size(217, 23);
            this.label_choose_teacher.TabIndex = 17;
            this.label_choose_teacher.Text = "Choose classroom teacher:";
            // 
            // label_classroom
            // 
            this.label_classroom.AutoSize = true;
            this.label_classroom.Location = new System.Drawing.Point(28, 302);
            this.label_classroom.Name = "label_classroom";
            this.label_classroom.Size = new System.Drawing.Size(155, 23);
            this.label_classroom.TabIndex = 19;
            this.label_classroom.Text = "Choose classroom:";
            // 
            // listbox_classroom
            // 
            this.listbox_classroom.FormattingEnabled = true;
            this.listbox_classroom.ItemHeight = 23;
            this.listbox_classroom.Location = new System.Drawing.Point(32, 328);
            this.listbox_classroom.Name = "listbox_classroom";
            this.listbox_classroom.Size = new System.Drawing.Size(442, 119);
            this.listbox_classroom.TabIndex = 18;
            // 
            // checkedLilistbox_students
            // 
            this.checkedLilistbox_students.CheckOnClick = true;
            this.checkedLilistbox_students.FormattingEnabled = true;
            this.checkedLilistbox_students.Location = new System.Drawing.Point(32, 653);
            this.checkedLilistbox_students.Name = "checkedLilistbox_students";
            this.checkedLilistbox_students.Size = new System.Drawing.Size(442, 186);
            this.checkedLilistbox_students.TabIndex = 20;
            // 
            // label_students
            // 
            this.label_students.AutoSize = true;
            this.label_students.Location = new System.Drawing.Point(28, 627);
            this.label_students.Name = "label_students";
            this.label_students.Size = new System.Drawing.Size(143, 23);
            this.label_students.TabIndex = 21;
            this.label_students.Text = "Choose students:";
            // 
            // label_learning_program
            // 
            this.label_learning_program.AutoSize = true;
            this.label_learning_program.Location = new System.Drawing.Point(28, 473);
            this.label_learning_program.Name = "label_learning_program";
            this.label_learning_program.Size = new System.Drawing.Size(209, 23);
            this.label_learning_program.TabIndex = 23;
            this.label_learning_program.Text = "Choose learning program:";
            // 
            // listbox_learning_program
            // 
            this.listbox_learning_program.FormattingEnabled = true;
            this.listbox_learning_program.ItemHeight = 23;
            this.listbox_learning_program.Location = new System.Drawing.Point(32, 499);
            this.listbox_learning_program.Name = "listbox_learning_program";
            this.listbox_learning_program.Size = new System.Drawing.Size(442, 119);
            this.listbox_learning_program.TabIndex = 22;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PanelAddStudentGroup
            // 
            this.AcceptButton = this.button_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(527, 927);
            this.Controls.Add(this.label_learning_program);
            this.Controls.Add(this.listbox_learning_program);
            this.Controls.Add(this.label_students);
            this.Controls.Add(this.checkedLilistbox_students);
            this.Controls.Add(this.label_classroom);
            this.Controls.Add(this.listbox_classroom);
            this.Controls.Add(this.label_choose_teacher);
            this.Controls.Add(this.listbox_classroom_teacher);
            this.Controls.Add(this.textbox_year_of_creation);
            this.Controls.Add(this.textbox_group_name);
            this.Controls.Add(this.label_year_of_creation);
            this.Controls.Add(this.laber_group_name);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PanelAddStudentGroup";
            this.Text = "Add Student Group";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelAddStudentGroup_FormClosing);
            this.Load += new System.EventHandler(this.PanelAddStudentGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textbox_year_of_creation;
        private System.Windows.Forms.TextBox textbox_group_name;
        private System.Windows.Forms.Label label_year_of_creation;
        private System.Windows.Forms.Label laber_group_name;
        private System.Windows.Forms.ListBox listbox_classroom_teacher;
        private System.Windows.Forms.Label label_choose_teacher;
        private System.Windows.Forms.Label label_classroom;
        private System.Windows.Forms.ListBox listbox_classroom;
        private System.Windows.Forms.CheckedListBox checkedLilistbox_students;
        private System.Windows.Forms.Label label_students;
        private System.Windows.Forms.Label label_learning_program;
        private System.Windows.Forms.ListBox listbox_learning_program;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}