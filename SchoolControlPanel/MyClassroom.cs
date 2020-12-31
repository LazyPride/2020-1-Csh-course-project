using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolControlPanel
{
    partial class classroom
    {
        public override string ToString()
        {
            string str = "";
            if (string.IsNullOrWhiteSpace(secondary_num))
            {
                str = String.Format("{0}", primary_num);
            }
            else
            {
                str = String.Format("{0}-{1}", primary_num, secondary_num);
            }

            if (student_group.Count > 0)
            {
                str += " (Occupied by";
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
                str += ")";
            }

            return str;
        }
    }
}
