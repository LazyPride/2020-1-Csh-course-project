using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolControlPanel
{
    partial class teacher
    {
        public override string ToString()
        {
            string str = String.Format("{0} {1} {2}", first_name, last_name, third_name);

            if (student_group.Count > 0)
            {
                str += " (Classrom teacher for";
            }

            foreach (student_group s in student_group)
            {
                if (s.id != -1)
                {
                    str += " " + s.name;
                }
            }

            if (student_group.Count > 0)
            {
                str += ") ";
            }

            if (subjects.Count > 0)
            {
                str += " (Teaches: ";
            }

            foreach (subject s in subjects)
            {
                if (s.id != -1)
                {
                    str += " " + s.name;
                }
            }

            if (subjects.Count > 0)
            {
                str += ")";
            }

            return str;
        }
    }
}
