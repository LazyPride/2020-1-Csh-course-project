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
                var popup_connection_established = new PopupConnectionEstablished();
                popup_connection_established.ShowDialog(this);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_add_teacher_Click(object sender, EventArgs e)
        {
            PanelAddTeacher panelAddTeacher = new PanelAddTeacher();
            panelAddTeacher.Show(this);

        }
    }
}
