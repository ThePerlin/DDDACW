using System;
using System.Collections.Generic;
using System.Text;

namespace DDDACW
{
    class Student : InteractiveUser 
    {
        public void SelfReport(User student)
        {
            int selfReportGrade;
            Console.Clear();
            Console.WriteLine("Please enter how you are feeling between 1 and 5");
            selfReportGrade = int.Parse(Console.ReadLine());

        }


    }
}
