namespace SchoolControlPanel
{
    partial class PanelAddSubject
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
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textbox_lesson_quantity = new System.Windows.Forms.TextBox();
            this.textbox_year_of_creation = new System.Windows.Forms.TextBox();
            this.textbox_lesson_name = new System.Windows.Forms.TextBox();
            this.label_lesson_quantity = new System.Windows.Forms.Label();
            this.label_year_of_creation = new System.Windows.Forms.Label();
            this.laber_lesson_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_confirm
            // 
            this.button_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_confirm.Location = new System.Drawing.Point(102, 176);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(100, 40);
            this.button_confirm.TabIndex = 9;
            this.button_confirm.Text = "Add";
            this.button_confirm.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(208, 176);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 40);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Close";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // textbox_lesson_quantity
            // 
            this.textbox_lesson_quantity.Location = new System.Drawing.Point(170, 120);
            this.textbox_lesson_quantity.MaxLength = 3;
            this.textbox_lesson_quantity.Name = "textbox_lesson_quantity";
            this.textbox_lesson_quantity.Size = new System.Drawing.Size(63, 31);
            this.textbox_lesson_quantity.TabIndex = 16;
            // 
            // textbox_year_of_creation
            // 
            this.textbox_year_of_creation.Location = new System.Drawing.Point(170, 79);
            this.textbox_year_of_creation.MaxLength = 4;
            this.textbox_year_of_creation.Name = "textbox_year_of_creation";
            this.textbox_year_of_creation.Size = new System.Drawing.Size(63, 31);
            this.textbox_year_of_creation.TabIndex = 15;
            // 
            // textbox_lesson_name
            // 
            this.textbox_lesson_name.Location = new System.Drawing.Point(170, 42);
            this.textbox_lesson_name.MaxLength = 3;
            this.textbox_lesson_name.Name = "textbox_lesson_name";
            this.textbox_lesson_name.Size = new System.Drawing.Size(292, 31);
            this.textbox_lesson_name.TabIndex = 14;
            // 
            // label_lesson_quantity
            // 
            this.label_lesson_quantity.AutoSize = true;
            this.label_lesson_quantity.Location = new System.Drawing.Point(27, 123);
            this.label_lesson_quantity.Name = "label_lesson_quantity";
            this.label_lesson_quantity.Size = new System.Drawing.Size(137, 23);
            this.label_lesson_quantity.TabIndex = 13;
            this.label_lesson_quantity.Text = "Lesson quantity:";
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
            // laber_lesson_name
            // 
            this.laber_lesson_name.AutoSize = true;
            this.laber_lesson_name.Location = new System.Drawing.Point(28, 50);
            this.laber_lesson_name.Name = "laber_lesson_name";
            this.laber_lesson_name.Size = new System.Drawing.Size(115, 23);
            this.laber_lesson_name.TabIndex = 11;
            this.laber_lesson_name.Text = "Lesson name:";
            // 
            // PanelAddSubject
            // 
            this.AcceptButton = this.button_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(495, 233);
            this.Controls.Add(this.textbox_lesson_quantity);
            this.Controls.Add(this.textbox_year_of_creation);
            this.Controls.Add(this.textbox_lesson_name);
            this.Controls.Add(this.label_lesson_quantity);
            this.Controls.Add(this.label_year_of_creation);
            this.Controls.Add(this.laber_lesson_name);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "PanelAddSubject";
            this.Text = "Add Subject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textbox_lesson_quantity;
        private System.Windows.Forms.TextBox textbox_year_of_creation;
        private System.Windows.Forms.TextBox textbox_lesson_name;
        private System.Windows.Forms.Label label_lesson_quantity;
        private System.Windows.Forms.Label label_year_of_creation;
        private System.Windows.Forms.Label laber_lesson_name;
    }
}