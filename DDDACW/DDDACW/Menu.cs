using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using static System.Collections.Specialized.BitVector32;

namespace DDDACW
{
    class Menu
    {
        public void DisplayWelcome(User user)
        {
            Console.WriteLine("Welcome to the departament of science supporting app! :-) ");

            if (user.type == UserType.STUDENT)
            {
                Console.WriteLine("Hi Student " + user.FirstName + " " + user.LastName);
            }
            else if (user.type == UserType.SUPERVISOR)
            {
                Console.WriteLine("Hi Personal Supervisor " + user.FirstName + " " + user.LastName);
            }
            else if (user.type == UserType.TUTOR)
            {
                Console.WriteLine("Hi Sernior Tutor " + user.FirstName + " " + user.LastName);
            }
            else
            {
                Console.WriteLine("Goodbye Strager!");
            }
        }

        public void DisplayLoginMenu()
        {
            
        }

        public string DisplayFailedLogin()
        {
            Console.Write("Your login failed. Press 0 to exit or any other key to try again.");
            return Console.ReadKey().KeyChar.ToString();
        }

        public void PressToConiunue()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        // Login: returns authenticated user or null otherwise
        public User Login()
        {
            string userID, password;
            User usr = new User();

            Console.Clear();
            Console.Write("Please enter your user ID :");
            userID = Console.ReadLine();

            Console.Clear();
            Console.Write("Please enter your password :");
            password = Console.ReadLine();

            Console.Clear();

            // TODO: check storage if user exists
            // check if password matches

            if (userID == "PS")
            {
                usr.type = UserType.SUPERVISOR;
            }
            else if (userID == "ST")
            {
                //Console.Write("SeniorTutor");
                usr.type = UserType.TUTOR;
            }
            else if (userID == "S")
            {
                // Console.Write("Student");
                usr.type = UserType.STUDENT;
            }
            else
            {
                usr = null;
            }

            return usr;
        }
        public void Logout()
        {
            Environment.Exit(0);
        }
        public int MainMenu(User user)
        {
            // show specific menu according to user type
            int resp = 0;

            if (user.type == UserType.STUDENT )
            {
                Console.WriteLine("1 : Self report");
                Console.WriteLine("2 : Show pending meeting request");
                Console.WriteLine("3 : Book a meeting");
                Console.WriteLine("0 : Logout");
                Console.Write    ("Plese enter 1 to 3 or 0 to logout:");

                resp = GetSelection(0,3);

            } 
            else if (user.type == UserType.SUPERVISOR)
            {
                Console.WriteLine("1 : Show students");
                Console.WriteLine("2 : Show pending meeting request");
                Console.WriteLine("3 : Book a meeting");
                Console.WriteLine("0 : Logout");
                Console.Write    ("Plese enter 1 to 3 or 0 to logout:");

                resp = GetSelection(0,3);
            } 
            else if (user.type == UserType.TUTOR)
            {
                Console.WriteLine("1 : Show students");
                Console.WriteLine("0 : Logout");
                Console.Write    ("Plese enter 1 or 0 to logout:");

                resp = GetSelection(0,1);
            }

            return resp;
        }

        public int SelfReportMenu()
        {
            int resp;

            Console.Clear();
            Console.WriteLine("Self Report: How do you feel?");
            Console.WriteLine("5 : Just Great!");
            Console.WriteLine("4 : Good");
            Console.WriteLine("3 : So,so");
            Console.WriteLine("2 : Bad");
            Console.WriteLine("1 : Awful");
            Console.WriteLine("0 : Cancel");
            Console.Write("Please choose from 1 to 5 or 0 to cancel:");

            resp = GetSelection(0, 5);

            return resp;
        }

        public int GetSelection(int minValue, int maxValue)
        {
            int selection = -1;

            try
            {
                selection = int.Parse(Console.ReadLine());
            }
            catch
            {  // user entered out of range or non-numeric value
                selection = -1; 
            }

            while (selection < minValue || selection > maxValue)
            {
                Console.Write("The number does not meet the criteria: " + minValue + "-" + maxValue + ", please try again:");
                try { selection = int.Parse(Console.ReadLine()); } catch { selection = -1; }
                //Console.Clear();
            }
                
            //Console.WriteLine("You have entered " + selection.ToString());
            return selection;
        }


    }
}
