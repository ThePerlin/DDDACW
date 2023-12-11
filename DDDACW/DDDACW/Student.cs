using System;
using System.Collections.Generic;
using System.Text;

namespace DDDACW
{
    class Student : InteractiveUser 
    {
        public UserType type = UserType.STUDENT;
        public void SelfReport()
        {

        }

        public void WhoAmI()
        {
            Console.WriteLine("I am STUDENT");
        }

    }
}
