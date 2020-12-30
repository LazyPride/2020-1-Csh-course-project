using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolControlPanel
{
    public class ValidatorNumber
    {
        private TextBox textBox;
        private ErrorProvider errorProvider;
        public ValidatorNumber(TextBox textBox, ErrorProvider errorProvider)
        {
            this.textBox = textBox;
            this.errorProvider = errorProvider;
        }
        public void Validating(object sender, CancelEventArgs e)
        {
            int number = 0;
            if (string.IsNullOrWhiteSpace(textBox.Text) || !int.TryParse(textBox.Text, out number))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, "Number is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
        }
    }
}
