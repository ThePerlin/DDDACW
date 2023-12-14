using System;
using System.Collections.Generic;
using System.Text;

namespace DDDACW
{
    class PersonalSupervisor : User
    {
        public UserType type = UserType.SUPERVISOR;

        public void PerformAction(int action)
        {
            switch (action)
            {
                case 1:
                    ShowStudents();
                    break;

                case 2:
                    BookMeeting();
                    break;

                default:
                    break;
            }
        }

        public void ShowStudents()
        {
            Student s = new Student();
            s.Read();
            s.Display();
        }

        public void BookMeeting()
        {
            Console.WriteLine("Not implemeted");

        }
        public UserType WhoAmI()
        {
            Console.WriteLine("I am SUPERVISOR");
            return type;
        }
    }

}
