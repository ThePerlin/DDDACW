using System;
using System.Collections.Generic;
using System.Text;

namespace DDDACW
{
    class PersonalSupervisor : User
    {
        public UserType type = UserType.SUPERVISOR;
       
        public void WhoAmI()
        {
            Console.WriteLine("I am SUPERVISOR");
        }
    }

}
