namespace SchoolControlPanel
{
    partial class PanelDeleteMark
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label_student = new System.Windows.Forms.Label();
            this.listbox_student = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button_confirm
            // 
            this.button_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_confirm.Location = new System.Drawing.Point(141, 152);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(100, 40);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "Delete";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(257, 152);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 40);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Close";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label_student
            // 
            this.label_student.AutoSize = true;
            this.label_student.Location = new System.Drawing.Point(19, 13);
            this.label_student.Name = "label_student";
            this.label_student.Size = new System.Drawing.Size(64, 23);
            this.label_student.TabIndex = 8;
            this.label_student.Text = "Marks:";
            // 
            // listbox_student
            // 
            this.listbox_student.FormattingEnabled = true;
            this.listbox_student.ItemHeight = 23;
            this.listbox_student.Location = new System.Drawing.Point(23, 50);
            this.listbox_student.Name = "listbox_student";
            this.listbox_student.Size = new System.Drawing.Size(462, 96);
            this.listbox_student.TabIndex = 9;
            this.listbox_student.SelectedIndexChanged += new System.EventHandler(this.listbox_student_SelectedIndexChanged);
            // 
            // PanelDeleteMark
            // 
            this.AcceptButton = this.button_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(509, 210);
            this.Controls.Add(this.listbox_student);
            this.Controls.Add(this.label_student);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PanelDeleteMark";
            this.Text = "Add Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelAddStudent_FormClosing);
            this.Load += new System.EventHandler(this.PanelAddMark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListBox listbox_student;
        private System.Windows.Forms.Label label_student;
    }
}