using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentDay24
{
    class UC11
    {
        public UC11()
        {
            UC11 Obj = new UC11();

            public string MultipleEmails(string e1, string e2)
            {
                bool b1 = Obj.ValidEmail(e1);

                bool b2 = Obj.ValidEmail(e2);

                if (b1 && b2)
                    return "Entry Successful";
                else
                    return "Entry Unsuccessful";

            }
        }
    }
}