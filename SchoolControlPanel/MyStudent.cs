using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolControlPanel
{
    partial class student
    {
        public override string ToString()
        {
            if (student_group_id == -1)
            {
                return String.Format("{0} {1} {2}", first_name, last_name, third_name);
            }
            return String.Format("{0} {1} {2} (In {3})", first_name, last_name, third_name, student_group.name);
        }

    }
}
