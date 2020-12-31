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
    public partial class PanelAddTeacher : Form
    {
        public PanelAddTeacher()
        {
            InitializeComponent();
            CausesValidation = false;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {

            

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                teacher t = new teacher
                {
                    first_name = text_box_teacher_first_name.Text,
                    last_name = text_box_teacher_last_name.Text,
                    third_name = text_box_teacher_third_name.Text,
                };



                using (schoolEntities db = new schoolEntities())
                {
                    int[] keys = checkedlistbox_subjects.CheckedItems.Cast<subject>().Select(s => s.id).ToArray();
                    foreach (var key in keys)
                    {
                        subject s = db.subjects.Find(key);
                        if (s != null)
                        {
                            s.teachers.Add(t);
                            t.subjects.Add(s);
                        }
                    }

                    db.teachers.Add(t);
                    db.SaveChanges();
                    MessageBox.Show(string.Format("Teacher {0} {1} {2} is added!", t.first_name, t.last_name, t.third_name), "Success!");
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelAddTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void PanelAddTeacher_Load(object sender, EventArgs e)
        {
            using (schoolEntities db = new schoolEntities())
            {
                checkedlistbox_subjects.Items.AddRange(db.subjects.ToArray<subject>());
            }
        }
    }
}
