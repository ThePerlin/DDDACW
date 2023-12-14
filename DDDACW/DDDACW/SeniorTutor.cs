using System;
using System.Collections.Generic;
using System.Text;

namespace DDDACW
{
    class SeniorTutor : InteractiveUser
    {
        public UserType type = UserType.TUTOR;
        public void PerformAction(int action)
        {
            if (action == 1)
            {
                ShowStudents();
            }
        }
        public void ShowStudents()
        {
            Student s = new Student();
            s.Read();
            s.Display();
        }
        public UserType WhoAmI()
        {
            Console.WriteLine("I am TUTOR");
            return type;
        }
    }
}
