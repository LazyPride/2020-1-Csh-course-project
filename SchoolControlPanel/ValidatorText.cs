using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolControlPanel
{
    public class ValidatorText
    {
        private TextBox textBox;
        private ErrorProvider errorProvider;
        public ValidatorText(TextBox textBox, ErrorProvider errorProvider)
        {
            this.textBox = textBox;
            this.errorProvider = errorProvider;
        }
        public void Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, "Text is requeired!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
        }
    }
}
