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
    public partial class MainFrame : Form
    {


        public MainFrame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (schoolEntities contextDB = new schoolEntities())
            {
                MessageBox.Show("Connection established!", "Success!");
            }
        }

        private void button_add_teacher_Click(object sender, EventArgs e)
        {
            PanelAddTeacher panelAddTeacher = new PanelAddTeacher();
            panelAddTeacher.Show(this);
        }

        private void button_add_classroom_Click(object sender, EventArgs e)
        {
            PanelAddClassroom panelAddClassroom = new PanelAddClassroom();
            panelAddClassroom.Show(this);
        }

        private void button_add_subject_Click(object sender, EventArgs e)
        {
            PanelAddSubject panelAddSubject = new PanelAddSubject();
            panelAddSubject.Show(this);
        }

        private void button_add_learning_program_Click(object sender, EventArgs e)
        {
            PanelAddLearningProgram panelAddLearningProgram = new PanelAddLearningProgram();
            panelAddLearningProgram.Show(this);
        }
    }
}
