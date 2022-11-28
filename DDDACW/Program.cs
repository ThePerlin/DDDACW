using System;

namespace DDDACW
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            User user = new User();

            user.type = UserType.STUDENT;

            user.Login();
            
            menu.DisplayWelcome();
            menu.MainMenu(user);
            

          

            menu.PressToConiunue();
            

           

            

        }
    }
}
