using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DDDACW
{
    public enum UserType { STUDENT, SUPERVISOR, TUTOR }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool PendingMeetingRequest { get; set; }
        public string userID { get; set; }
        public string password;
        public UserType type;
        public string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "students.json");

        public bool HasPendingMeetingRequest()
        {      
            return PendingMeetingRequest;
        }
        
        public void WhoAmI()
        {
            Console.WriteLine("I am USER");
        }

    }
}
