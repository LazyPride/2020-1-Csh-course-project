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
    public partial class PanelDiary : Form
    {
        public PanelDiary()
        {
            InitializeComponent();
            CausesValidation = false;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PanelAddClassroom_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

  
        private void PanelDiary_Load(object sender, EventArgs e)
        {
            using (schoolEntities db = new schoolEntities())
            {
                listBox1.Items.AddRange(db.students.Where(c => c.id != -1).ToArray<student>());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int keyStudent = ((student)listBox1.SelectedItem).id;
            using (schoolEntities db = new schoolEntities())
            {
                listBox2.Items.Clear();
                
                listBox2.Items.AddRange(
                    db.lesson_mark
                    .Where(c => c.student_id == keyStudent)
                    .Select(mark => mark.subject.name + " #" + mark.lesson_number + " - " + mark.lesson_mark1)
                    .ToArray()
                    );
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
