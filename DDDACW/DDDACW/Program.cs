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

            while (signin != "0") {

                user = menu.Login();

                if (user != null)
                {
                    int choice = 1;
                    menu.DisplayWelcome(user);

                    while (choice != 0)
                    {
                        choice = menu.MainMenu(user);

                        Console.WriteLine("You have entered " + choice.ToString());
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
