namespace SchoolControlPanel
{
    partial class PanelAddClassroom
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
            this.laber_number = new System.Windows.Forms.Label();
            this.label_character = new System.Windows.Forms.Label();
            this.label_floor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // laber_number
            // 
            this.laber_number.AutoSize = true;
            this.laber_number.Location = new System.Drawing.Point(31, 31);
            this.laber_number.Name = "laber_number";
            this.laber_number.Size = new System.Drawing.Size(78, 23);
            this.laber_number.TabIndex = 2;
            this.laber_number.Text = "Number:";
            // 
            // label_character
            // 
            this.label_character.AutoSize = true;
            this.label_character.Location = new System.Drawing.Point(31, 64);
            this.label_character.Name = "label_character";
            this.label_character.Size = new System.Drawing.Size(90, 23);
            this.label_character.TabIndex = 3;
            this.label_character.Text = "Character:";
            // 
            // label_floor
            // 
            this.label_floor.AutoSize = true;
            this.label_floor.Location = new System.Drawing.Point(31, 98);
            this.label_floor.Name = "label_floor";
            this.label_floor.Size = new System.Drawing.Size(55, 23);
            this.label_floor.TabIndex = 4;
            this.label_floor.Text = "Floor:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 23);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            validatorNumber1 = new ValidatorNumber(textBox1, errorProvider);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.validatorNumber1.Validating);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 61);
            this.textBox2.MaxLength = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(31, 31);
            this.textBox2.TabIndex = 6;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 98);
            this.textBox3.MaxLength = 3;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 31);
            this.textBox3.TabIndex = 7;
            validatorNumber2 = new ValidatorNumber(textBox3, errorProvider);
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.validatorNumber2.Validating);
            // 
            // button_confirm
            // 
            this.button_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_confirm.Location = new System.Drawing.Point(35, 158);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(100, 40);
            this.button_confirm.TabIndex = 8;
            this.button_confirm.Text = "Add";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(141, 158);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 40);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Close";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PanelAddClassroom
            // 
            this.AcceptButton = this.button_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(286, 239);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_floor);
            this.Controls.Add(this.label_character);
            this.Controls.Add(this.laber_number);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PanelAddClassroom";
            this.Text = "Add Classroom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PanelAddClassroom_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label laber_number;
        private System.Windows.Forms.Label label_character;
        private System.Windows.Forms.Label label_floor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        ValidatorNumber validatorNumber1;
        ValidatorNumber validatorNumber2;
    }
}