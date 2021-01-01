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
    public partial class PanelDeleteMark : Form
    {
        ValidatorNumber validator1;
        ValidatorNumber validator2;
        ValidatorListBox validatorList1;
        ValidatorListBox validatorList2;
        public PanelDeleteMark()
        {
            InitializeComponent();
            CausesValidation = false;
            AutoValidate = AutoValidate.EnableAllowFocusChange;

            validatorList2 = new ValidatorListBox(listbox_student, errorProvider);

            this.listbox_student.Validating += new System.ComponentModel.CancelEventHandler(this.validatorList2.Validating);
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                object[] keys = new object[4];
                keys[0] = ((object)((lesson_mark)listbox_student.SelectedItem).lesson_timestamp);
                keys[1] = ((object)((lesson_mark)listbox_student.SelectedItem).student_id);
                keys[2] = ((object)((lesson_mark)listbox_student.SelectedItem).subject_id);
                keys[3] = ((object)((lesson_mark)listbox_student.SelectedItem).lesson_number);

                using (schoolEntities db = new schoolEntities())
                {
                    db.lesson_mark.Remove(db.lesson_mark.Find(keys));
                    db.SaveChanges();

                    listbox_student.Items.Clear();
                    listbox_student.Items.AddRange(db.lesson_mark.ToArray());

                    MessageBox.Show(string.Format("Mark is deleted!"), "Success!");
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelAddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void PanelAddMark_Load(object sender, EventArgs e)
        {
            using (schoolEntities db = new schoolEntities())
            {
                listbox_student.Items.AddRange(db.lesson_mark.ToArray());
            }
        }

        private void listbox_student_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
