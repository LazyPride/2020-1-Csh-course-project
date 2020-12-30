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
    public partial class PanelAddStudent : Form
    {
        public PanelAddStudent()
        {
            InitializeComponent();
            CausesValidation = false;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                student t = new student
                {
                    first_name = text_box_student_first_name.Text,
                    last_name = text_box_student_last_name.Text,
                    third_name = text_box_student_third_name.Text,
                    student_group_id = 0
                };

                using (schoolEntities db = new schoolEntities())
                {
                    db.students.Add(t);
                    db.SaveChanges();
                    MessageBox.Show(string.Format("Student {0} {1} {2} is added!", t.first_name, t.last_name, t.third_name), "Success!");
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_box_student_first_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text_box_student_first_name.Text))
            {
                e.Cancel = true;
                PanelAddTeacherErrorProvider.SetError(text_box_student_first_name, "Requeired!");
            }
            else
            {
                e.Cancel = false;
                PanelAddTeacherErrorProvider.SetError(text_box_student_first_name, null);
            }
        }

        private void PanelAddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void text_box_student_last_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text_box_student_last_name.Text))
            {
                e.Cancel = true;
                PanelAddTeacherErrorProvider.SetError(text_box_student_last_name, "Requeired!");
            }
            else
            {
                e.Cancel = false;
                PanelAddTeacherErrorProvider.SetError(text_box_student_last_name, null);
            }
        }
    }
}
