using System;
using System.Net;

namespace DDDACW
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            User user;

            string signin = "1";

            while (signin != "0") 
            {
                user = menu.Login();

                if (user != null)
                {
                    int choice = 1;
                    menu.DisplayWelcome(user);

                    Student s = new Student();
                    PersonalSupervisor ps = new PersonalSupervisor();
                    SeniorTutor t = new SeniorTutor();
                   
                    while (choice != 0)
                    {
                        choice = menu.MainMenu(user);

                        if (user.type == UserType.STUDENT)
                            s.PerformAction(choice);
                        else if (user.type == UserType.SUPERVISOR)
                            ps.PerformAction(choice);
                        else if (user.type == UserType.TUTOR)
                            t.PerformAction(choice);

                        //Console.WriteLine("You have entered " + choice.ToString());
                        menu.PressToConiunue();
                        Console.Clear();
                    }
                    menu.Logout();
                } 
                else
                {
                    signin = menu.DisplayFailedLogin();
                }
            }
        }
    }
}
