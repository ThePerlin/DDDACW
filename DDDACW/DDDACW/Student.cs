using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace DDDACW
{

    public class Student : InteractiveUser
    {
        // Specify the file path

        public string SelfReportScore { get; set; }

        public Student()
        {
            type = UserType.STUDENT;
        }


        public void PerformAction(int action)
        {
            switch (action)
            {
                case 1:
                    SelfReport();
                    break;

                case 2:
                    Read();
                    Display();
                    break;

                case 3:
                    BookMeeting();
                    break;

                default:
                    break;
            }
        }

        public void SelfReport()
        {
            Menu menu = new Menu();
            this.SelfReportScore = menu.SelfReportMenu().ToString();

            this.Save();
        }

        public void BookMeeting()
        {
            Console.WriteLine("Not implemeted");

        }
        public UserType WhoAmI()
        {
            Console.WriteLine("I am STUDENT");
            return type;
        }

        public void Save()
        {
            // Json data
            var JsonData = new
            {
                FirstName = "John",
                LastName = "Doe",
                userID = "S",
                SelfReportScore = this.SelfReportScore
            };

            // Write JSON data to file
            JsonFileManager.WriteToJsonFile(filePath, JsonData);
        }

        public void Read()
        {
            // Read JSON data from file
            if (File.Exists(filePath))
            {
                var readData = JsonFileManager.ReadFromJsonFile<Student>(filePath);

                this.FirstName = readData.FirstName;
                this.LastName = readData.LastName;
                this.userID = readData.userID;
                this.SelfReportScore = readData.SelfReportScore;
            }

            // Output the read data
            //if (readData != null)
            //{
            //    Console.WriteLine($"First: {readData.FirstName}");
            //    Console.WriteLine($"Last: {readData.LastName}");
            //    Console.WriteLine($"SelfReportScore: {readData.SelfReportScore}");
            //}
        }
        public void Display()
        {
            Console.WriteLine($"First: {FirstName}");
            Console.WriteLine($"First: {LastName}");
            Console.WriteLine($"UserID: {userID}");
            Console.WriteLine($"Self Report Score: {SelfReportScore}");
        }

        public void BookMeetig()
        {
            Console.WriteLine("Not implemeted");
           
        }
    }
}
