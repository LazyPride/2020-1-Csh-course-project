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
    public partial class PanelAddStudentGroup : Form
    {
        private ValidatorText validator1;
        private ValidatorNumber validator2;
        private ValidatorListBox validatorList1;
        private ValidatorListBox validatorList2;
        private ValidatorListBox validatorList3;
        private ValidatorCheckedListBox validatorCheck;
        public PanelAddStudentGroup()
        {
            InitializeComponent();
            CausesValidation = false;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            validator1 = new ValidatorText(textbox_group_name, errorProvider);
            validator2 = new ValidatorNumber(textbox_year_of_creation, errorProvider);
            
            validatorList1 = new ValidatorListBox(listbox_classroom, errorProvider);
            validatorList2 = new ValidatorListBox(listbox_classroom_teacher, errorProvider);
            validatorList3 = new ValidatorListBox(listbox_learning_program, errorProvider);
            
            validatorCheck = new ValidatorCheckedListBox(checkedLilistbox_students, errorProvider);

            this.textbox_group_name.Validating += new System.ComponentModel.CancelEventHandler(this.validator1.Validating);
            this.textbox_year_of_creation.Validating += new System.ComponentModel.CancelEventHandler(this.validator2.Validating);
            
            this.listbox_classroom.Validating += new System.ComponentModel.CancelEventHandler(this.validatorList1.Validating);
            this.listbox_classroom_teacher.Validating += new System.ComponentModel.CancelEventHandler(this.validatorList2.Validating);
            this.listbox_learning_program.Validating += new System.ComponentModel.CancelEventHandler(this.validatorList3.Validating);
            
            this.checkedLilistbox_students.Validating += new System.ComponentModel.CancelEventHandler(this.validatorCheck.Validating);

        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                student_group t = new student_group
                {
                    name = textbox_group_name.Text,
                    entry_year = int.Parse(textbox_year_of_creation.Text),
                };

                int keyClassroom = ((classroom)listbox_classroom.SelectedItem).id;
                int keyTeacher = ((teacher)listbox_classroom_teacher.SelectedItem).id;
                int keyLearning = ((learning_program)listbox_learning_program.SelectedItem).id;
                int[] keys = checkedLilistbox_students.CheckedItems.Cast<student>().Select(s => s.id).ToArray();


                using (schoolEntities db = new schoolEntities())
                {
                    t.classroom = db.classrooms.Find(keyClassroom);
                    t.teacher = db.teachers.Find(keyTeacher);
                    t.learning_program = db.learning_program.Find(keyLearning);
                    db.student_group.Add(t);
                    foreach (var key in keys)
                    {
                        student s = db.students.Find(key);
                        if (s != null)
                        {
                            s.student_group = t;
                        }
                    }
                    db.SaveChanges();
                    MessageBox.Show(string.Format("Student group {0} (Year: {1}) is added!", t.name, t.entry_year), "Success!");

                    this.textbox_group_name.Clear();
                    this.textbox_year_of_creation.Clear();

                    this.listbox_classroom.ClearSelected();
                    this.listbox_classroom_teacher.ClearSelected();
                    this.listbox_learning_program.ClearSelected();

                    this.checkedLilistbox_students.ClearSelected();

                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PanelAddStudentGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void PanelAddStudentGroup_Load(object sender, EventArgs e)
        {
            using (schoolEntities db = new schoolEntities())
            {
                listbox_classroom.Items.AddRange(db.classrooms.Where(c => c.id != -1).ToArray<classroom>());
                listbox_classroom_teacher.Items.AddRange(db.teachers.Where(c => c.id != -1).ToArray<teacher>());
                listbox_learning_program.Items.AddRange(db.learning_program.Where(c => c.id != -1).ToArray<learning_program>());
                checkedLilistbox_students.Items.AddRange(db.students.Where(c => c.id != -1).ToArray<student>());
            }
        }
    }
}
