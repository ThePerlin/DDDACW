using System;
using System.Collections.Generic;
using System.Text;

namespace DDDACW
{
    public enum UserType { STUDENT, SUPERVISOR, TUTOR }
   

    class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userID;
        public string password;
        public UserType type;
        public bool pendingMeetingRequest;
       
        public bool HasPendingMeetingRequest(User user)
        {      
            return pendingMeetingRequest;
        }
        
        public void WhoAmI()
        {
            Console.WriteLine("I am USER");
        }
    }
}
