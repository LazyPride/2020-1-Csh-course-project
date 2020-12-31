using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolControlPanel
{
    partial class lesson_mark
    {
        public override string ToString()
        {
            return String.Format("mark {0} for lesson #{1}.({2})", lesson_mark1, lesson_number, lesson_timestamp);
        }

        public string getInfo()
        {
            return String.Format("mark {0} for lesson #{1}.({2})", lesson_mark1, lesson_number, lesson_timestamp);
        }
    }
}
