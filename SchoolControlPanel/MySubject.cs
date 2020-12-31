using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolControlPanel
{
    partial class subject
    {
        public override string ToString()
        {
            return String.Format("{0} (Year: {1}, Quantity:{2})", name, year_of_creation, quantity);
        }
    }
}
