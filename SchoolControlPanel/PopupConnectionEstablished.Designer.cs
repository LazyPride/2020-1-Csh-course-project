namespace SchoolControlPanel
{
    partial class PopupConnectionEstablished
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
            this.label_connection_success = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_connection_success
            // 
            this.label_connection_success.AutoSize = true;
            this.label_connection_success.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_connection_success.Location = new System.Drawing.Point(29, 43);
            this.label_connection_success.Name = "label_connection_success";
            this.label_connection_success.Size = new System.Drawing.Size(217, 26);
            this.label_connection_success.TabIndex = 0;
            this.label_connection_success.Text = "Connection established!";
            this.label_connection_success.Click += new System.EventHandler(this.label1_Click);
            // 
            // PopupConnectionEstablished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.label_connection_success);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopupConnectionEstablished";
            this.Text = "Success!";
            this.Load += new System.EventHandler(this.PopupConnectionEstablished_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_connection_success;
    }
}