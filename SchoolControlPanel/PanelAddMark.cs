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
    public partial class PanelAddMark : Form
    {
        ValidatorNumber validator1;
        ValidatorNumber validator2;
        ValidatorListBox validatorList1;
        ValidatorListBox validatorList2;
        public PanelAddMark()
        {
            InitializeComponent();
            CausesValidation = false;
            AutoValidate = AutoValidate.EnableAllowFocusChange;

            validator1 = new ValidatorNumber(text_mark, errorProvider);
            validator2 = new ValidatorNumber(text_lesson_number, errorProvider);
            validatorList1 = new ValidatorListBox(listbox_subject, errorProvider);
            validatorList2 = new ValidatorListBox(listbox_student, errorProvider);

            this.text_mark.Validating += new System.ComponentModel.CancelEventHandler(this.validator1.Validating);
            this.text_lesson_number.Validating += new System.ComponentModel.CancelEventHandler(this.validator2.Validating);
            this.listbox_subject.Validating += new System.ComponentModel.CancelEventHandler(this.validatorList1.Validating);
            this.listbox_student.Validating += new System.ComponentModel.CancelEventHandler(this.validatorList2.Validating);
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                int keyStudent = ((student)listbox_student.SelectedItem).id;
                int keySubject = ((subject)listbox_subject.SelectedItem).id;

                using (schoolEntities db = new schoolEntities())
                {
                    lesson_mark mark = new lesson_mark
                    {
                        lesson_timestamp = DateTime.Now,
                        student = db.students.Find(keyStudent),
                        subject = db.subjects.Find(keySubject),
                        lesson_mark1 = int.Parse(text_mark.Text),
                        lesson_number = int.Parse(text_lesson_number.Text)
                    };
                    db.lesson_mark.Add(mark);
                   
                    db.SaveChanges();
                    MessageBox.Show(string.Format("Mark is added!"), "Success!");
                    this.text_mark.Clear();
                    this.text_lesson_number.Clear();
                    this.listbox_subject.ClearSelected();
                    this.listbox_student.ClearSelected();
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
                listbox_student.Items.AddRange(db.students.Where(c => c.id != -1).ToArray());
                listbox_subject.Items.AddRange(db.subjects.Where(c => c.id != -1).ToArray());
            }
        }
    }
}
