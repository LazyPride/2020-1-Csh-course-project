using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolControlPanel
{
    public class ValidatorCheckedListBox
    {
        private CheckedListBox checkBox;
        private ErrorProvider errorProvider;
        public ValidatorCheckedListBox(CheckedListBox checkBox, ErrorProvider errorProvider)
        {
            this.checkBox = checkBox;
            this.errorProvider = errorProvider;
        }
        public void Validating(object sender, CancelEventArgs e)
        {
            if (checkBox.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(checkBox, "You have to choose at least one!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(checkBox, null);
            }
        }
    }
}
