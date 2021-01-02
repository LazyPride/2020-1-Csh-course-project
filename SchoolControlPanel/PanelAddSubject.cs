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
    public partial class PanelAddSubject : Form
    {
        private ValidatorNumber validator_year;
        private ValidatorNumber validator_q;
        private ValidatorText validator_name;
        public PanelAddSubject()
        {
            InitializeComponent();
            CausesValidation = false;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            validator_year = new ValidatorNumber(textbox_year_of_creation, errorProvider);
            validator_q = new ValidatorNumber(textbox_lesson_quantity, errorProvider);
            validator_name = new ValidatorText(textbox_lesson_name, errorProvider);
            this.textbox_lesson_name.Validating += new System.ComponentModel.CancelEventHandler(validator_name.Validating);
            this.textbox_year_of_creation.Validating += new System.ComponentModel.CancelEventHandler(validator_year.Validating);
            this.textbox_lesson_quantity.Validating += new System.ComponentModel.CancelEventHandler(validator_q.Validating);
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                subject c = new subject
                {
                    name = textbox_lesson_name.Text,
                    quantity = int.Parse(textbox_lesson_quantity.Text),
                    year_of_creation = int.Parse(textbox_year_of_creation.Text)
                };

                using (schoolEntities db = new schoolEntities())
                {
                    db.subjects.Add(c);
                    db.SaveChanges();
                    MessageBox.Show(string.Format("Subject {0} (Y:{2}, Q:{1}) is added!", c.name, c.quantity, c.year_of_creation), "Success!");
                }
                this.textbox_lesson_name.Clear();
                this.textbox_year_of_creation.Clear();
                this.textbox_lesson_quantity.Clear();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PanelAddSubject_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

    }
}
