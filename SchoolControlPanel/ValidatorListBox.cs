using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolControlPanel
{
    public class ValidatorListBox
    {
        private ListBox listBox;
        private ErrorProvider errorProvider;
        public ValidatorListBox(ListBox listBox, ErrorProvider errorProvider)
        {
            this.listBox = listBox;
            this.errorProvider = errorProvider;
        }
        public void Validating(object sender, CancelEventArgs e)
        {
            if (listBox.SelectedItems.Count != 1)
            {
                e.Cancel = true;
                errorProvider.SetError(listBox, "You have to choose one!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(listBox, null);
            }
        }
    }
}
