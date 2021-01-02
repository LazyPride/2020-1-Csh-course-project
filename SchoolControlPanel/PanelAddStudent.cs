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
        private ValidatorText validatorText_first_name;
        private ValidatorText validatorText_last_name;
        public PanelAddStudent()
        {
            InitializeComponent();
            CausesValidation = false;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            validatorText_first_name = new ValidatorText(text_box_student_first_name, PanelAddTeacherErrorProvider);
            validatorText_last_name = new ValidatorText(text_box_student_last_name, PanelAddTeacherErrorProvider);

            this.text_box_student_first_name.Validating += new System.ComponentModel.CancelEventHandler(this.validatorText_first_name.Validating);
            this.text_box_student_last_name.Validating += new System.ComponentModel.CancelEventHandler(this.validatorText_last_name.Validating);
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
                    student_group_id = -1
                };

                using (schoolEntities db = new schoolEntities())
                {
                    db.students.Add(t);
                    db.SaveChanges();
                    MessageBox.Show(string.Format("Student {0} {1} {2} is added!", t.first_name, t.last_name, t.third_name), "Success!");
                    text_box_student_first_name.Clear();
                    text_box_student_last_name.Clear();
                    text_box_student_third_name.Clear();
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

    }
}
