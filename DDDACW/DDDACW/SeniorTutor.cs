using System;
using System.Collections.Generic;
using System.Text;

namespace DDDACW
{
    class SeniorTutor : InteractiveUser
    {
        public UserType type = UserType.TUTOR;
        public int menuMaxSel = 1;
        public void GetMyStudents()
        {

        }
        public void WhoAmI()
        {
            Console.WriteLine("I am TUTOR");
        }
    }
}
