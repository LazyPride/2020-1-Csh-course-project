using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolControlPanel
{
    public partial class PanelAddClassroom : Form
    {
        public PanelAddClassroom()
        {
            InitializeComponent();
            CausesValidation = false;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                classroom c = new classroom
                {
                    primary_num = int.Parse(textBox1.Text),
                    secondary_num = textBox2.Text,
                    floor = int.Parse(textBox3.Text)
                };

                using (schoolEntities db = new schoolEntities())
                {
                    db.classrooms.Add(c);
                    db.SaveChanges();
                    MessageBox.Show(string.Format("Classroom {0}-{1} on {2} floor is added!", c.primary_num, c.secondary_num, c.floor), "Success!");
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PanelAddClassroom_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int number = 0;
            if (int.TryParse(textBox1.Text, out number))
            {
                textBox3.Text = number.ToString().Substring(0, 1);
            }
        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.TextLength > 0)
            {
                if (!char.IsLetter(textBox2.Text[0]))
                {
                    e.Cancel = true;
                    errorProvider.SetError(textBox2, "Only letter is acceptable.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(textBox2, null);
                }
            }
        }

    }
}
