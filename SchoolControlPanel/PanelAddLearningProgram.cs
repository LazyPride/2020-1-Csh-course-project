using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolControlPanel
{
    public partial class PanelAddLearningProgram : Form
    {
        private ValidatorText validator1;
        private ValidatorNumber validator2;
        private ValidatorCheckedListBox validator3;

        public PanelAddLearningProgram()
        {
            InitializeComponent();
            CausesValidation = false;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            validator1 = new ValidatorText(textbox_lesson_name, errorProvider);
            validator2 = new ValidatorNumber(textbox_year_of_creation, errorProvider);
            validator3 = new ValidatorCheckedListBox(checkedlistbox_subjects, errorProvider);

            this.textbox_lesson_name.Validating += new System.ComponentModel.CancelEventHandler(this.validator1.Validating);
            this.textbox_year_of_creation.Validating += new System.ComponentModel.CancelEventHandler(this.validator2.Validating);
            this.checkedlistbox_subjects.Validating += new System.ComponentModel.CancelEventHandler(this.validator3.Validating);
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {            
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                learning_program program = new learning_program
                {
                    name = textbox_lesson_name.Text,
                    year_of_creation = int.Parse(textbox_year_of_creation.Text)
                };

                using (schoolEntities db = new schoolEntities())
                {
                    db.learning_program.Add(program);

                    
                    int[] keys = checkedlistbox_subjects.CheckedItems.Cast<subject>().Select(s => s.id).ToArray();
                    foreach (var key in keys)
                    {
                        subject s = db.subjects.Find(key);
                        if (s != null)
                        {
                            s.learning_program1.Add(program);
                            program.subjects1.Add(s);
                        }
                    }
                    
                    db.SaveChanges();
                    MessageBox.Show(string.Format("Learning program is added!"), "Success!");
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelAddLearningProgram_Load(object sender, EventArgs e)
        {
            using (schoolEntities db = new schoolEntities())
            {
                checkedlistbox_subjects.Items.AddRange(db.subjects.ToArray<subject>());
            }

        }

        private void PanelAddLearningProgram_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
