namespace SchoolControlPanel
{
    partial class PanelAddLearningProgram
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
            this.textbox_lesson_name = new System.Windows.Forms.TextBox();
            this.label_year_of_creation = new System.Windows.Forms.Label();
            this.laber_name = new System.Windows.Forms.Label();
            this.checkedlistbox_subjects = new System.Windows.Forms.CheckedListBox();
            this.label_subject_list = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button_confirm
            // 
            this.button_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_confirm.Location = new System.Drawing.Point(217, 370);
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
            this.button_cancel.Location = new System.Drawing.Point(323, 370);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 40);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Close";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textbox_year_of_creation
            // 
            this.textbox_year_of_creation.Location = new System.Drawing.Point(239, 84);
            this.textbox_year_of_creation.MaxLength = 4;
            this.textbox_year_of_creation.Name = "textbox_year_of_creation";
            this.textbox_year_of_creation.Size = new System.Drawing.Size(63, 31);
            this.textbox_year_of_creation.TabIndex = 15;
            // 
            // textbox_lesson_name
            // 
            this.textbox_lesson_name.Location = new System.Drawing.Point(239, 47);
            this.textbox_lesson_name.MaxLength = 65536;
            this.textbox_lesson_name.Name = "textbox_lesson_name";
            this.textbox_lesson_name.Size = new System.Drawing.Size(292, 31);
            this.textbox_lesson_name.TabIndex = 14;
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
            // laber_name
            // 
            this.laber_name.AutoSize = true;
            this.laber_name.Location = new System.Drawing.Point(28, 50);
            this.laber_name.Name = "laber_name";
            this.laber_name.Size = new System.Drawing.Size(199, 23);
            this.laber_name.TabIndex = 11;
            this.laber_name.Text = "Learning program name:";
            // 
            // checkedlistbox_subjects
            // 
            this.checkedlistbox_subjects.CheckOnClick = true;
            this.checkedlistbox_subjects.FormattingEnabled = true;
            this.checkedlistbox_subjects.HorizontalScrollbar = true;
            this.checkedlistbox_subjects.Location = new System.Drawing.Point(32, 152);
            this.checkedlistbox_subjects.Name = "checkedlistbox_subjects";
            this.checkedlistbox_subjects.Size = new System.Drawing.Size(632, 212);
            this.checkedlistbox_subjects.TabIndex = 16;
            // 
            // label_subject_list
            // 
            this.label_subject_list.AutoSize = true;
            this.label_subject_list.Location = new System.Drawing.Point(28, 115);
            this.label_subject_list.Name = "label_subject_list";
            this.label_subject_list.Size = new System.Drawing.Size(140, 23);
            this.label_subject_list.TabIndex = 17;
            this.label_subject_list.Text = "Choose subjects:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PanelAddLearningProgram
            // 
            this.AcceptButton = this.button_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(682, 419);
            this.Controls.Add(this.label_subject_list);
            this.Controls.Add(this.checkedlistbox_subjects);
            this.Controls.Add(this.textbox_year_of_creation);
            this.Controls.Add(this.textbox_lesson_name);
            this.Controls.Add(this.label_year_of_creation);
            this.Controls.Add(this.laber_name);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PanelAddLearningProgram";
            this.Text = "Add Learning Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelAddLearningProgram_FormClosing);
            this.Load += new System.EventHandler(this.PanelAddLearningProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textbox_year_of_creation;
        private System.Windows.Forms.TextBox textbox_lesson_name;
        private System.Windows.Forms.Label label_year_of_creation;
        private System.Windows.Forms.Label laber_name;
        private System.Windows.Forms.CheckedListBox checkedlistbox_subjects;
        private System.Windows.Forms.Label label_subject_list;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}