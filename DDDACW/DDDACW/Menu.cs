using System;
using System.Collections.Generic;
using System.Text;

namespace DDDACW
{
    class Menu
    {

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the departament of science supporting app! :-/ ");
        }

        public void DisplayLoginMenu()
        {
            
        }

        public void PressToConiunue()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        
        public void MainMenu(User user)
        {
            //show specific menu acording to user type

            if (user.type == UserType.STUDENT )
            {
                Console.WriteLine("Hi " + user.firstName + user.lastName);
                Console.WriteLine("1 : Self report");
                Console.WriteLine("2 : Show pending meeting request");
                Console.WriteLine("3 : Book a meeting");
                Console.WriteLine("4 : Logout");
                EnterSelection(MaxSelection(user));
                
            }

            if (user.type == UserType.PERSONAL_SUPERVISOR)
            {
                Console.WriteLine("Hi " + user.firstName + user.lastName + " please enter from 1 to 4 what would you like to do");
                Console.WriteLine("1 : Show students");
                Console.WriteLine("2 : Show pending meeting request");
                Console.WriteLine("3 : Book a meeting");
                Console.WriteLine("4 : Logout");
                EnterSelection(MaxSelection(user));
            }

            if (user.type == UserType.SENIOR_TUTOR)
            {
                Console.WriteLine("Hi " + user.firstName + user.lastName + " please enter from 1 to 2 what would you like to do");
                Console.WriteLine("1 : Show students");
                Console.WriteLine("2 : Logout");
                EnterSelection(MaxSelection(user));
            }
        }

        public int EnterSelection(int maxValue)
        {
            Console.WriteLine("Please enter a number between 1 and " + maxValue + " choosing what would you like to do ");
            int selection = int.Parse(Console.ReadLine());
            Console.Clear();
            
            while (selection > maxValue)
            {
                
                Console.WriteLine("The number does not meet the criteria, please try again");
                selection = int.Parse(Console.ReadLine());
            }
                if (selection<= maxValue)
                {
                    Console.WriteLine("You have entered " + selection);
                }
                else
                {
                    Console.WriteLine("The number does not meet the criteria");
                }

            return selection; 
        }

    

        public int MaxSelection(User user)
        {
            int maxSelection;
            if (user.type == UserType.STUDENT || user.type == UserType.PERSONAL_SUPERVISOR)
            {
                maxSelection = 4;
                return maxSelection;
            }
            else
            {
                maxSelection = 2;
                return maxSelection;
            }
        }
    }
}
