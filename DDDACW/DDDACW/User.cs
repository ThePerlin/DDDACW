using System;
using System.Collections.Generic;
using System.Text;

namespace DDDACW
{
    public enum UserType { STUDENT, PERSONAL_SUPERVISOR, SENIOR_TUTOR }
    class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userID;
        public string password;
        public UserType type;
        public bool pendingMeetingRequest;

        public void Login()
        {
            Console.Write("Please enter your user ID :");
            userID = Console.ReadLine();
            Console.Clear();
            Console.Write("Please enter your password :");
            password = Console.ReadLine();
            Console.Clear();

            //check userID and password to be implemented
            //enter file 
            //check for match

        }
        public bool HasPendingMeetingRequest(User user)
        {
             
            

            return pendingMeetingRequest;
    }

    }
}
