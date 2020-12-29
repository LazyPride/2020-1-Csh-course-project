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
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            teacher t = new teacher
            {
                first_name = text_box_teacher_first_name.Text,
                last_name = text_box_teacher_last_name.Text,
                third_name = text_box_teacher_third_name.Text
            };

            using (schoolEntities db = new schoolEntities())
            {
                db.teachers.Add(t);
                db.SaveChanges();
                MessageBox.Show(string.Format("Teacher {0} {1} {2} is added!", t.first_name, t.last_name, t.third_name), "Success!");
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
