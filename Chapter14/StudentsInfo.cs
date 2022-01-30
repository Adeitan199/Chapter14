using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoOnClasses
{
    class StudentsInfo
    {

        public string FirstName;

        public string Surname;

        public string Course;

        public string Subject;

        public string University;

        public string EmailAdd;

        public long PhoneNum;

        //Number 3. Static field for each of the objects
        public static string studentname;
        public static string studentUniversity;
        public static string studentcourse;
        public static long studentPhoneNo;
        public static string emailAddr;
        public static string subject;


        //Number 2 . Constructors

        public StudentsInfo(string firstName, string surName, string course)
        {
            FirstName = firstName;
            Surname = surName;
            Course = course;
        }

        public StudentsInfo(string subject, string university, string emailadd, long phoneNum)
        {
            Subject = subject;
            University = university;
            EmailAdd = emailadd;
            PhoneNum = phoneNum;
        }


        public string GetName()
        {
            return studentname;
        }

        public void SetName(string aName)
        {
            studentname = aName;
        }


        public static void StudentInfo()
        {
            Console.WriteLine($"Dear {studentname}, you are welcone to {studentUniversity}, your course is {studentcourse} " +
                $"and your Email Address is {emailAddr}");
        }


        public class Student
        {
            //Properties for the data
            private string FirstName {get; set;}

            private string Surname { get; set;}

            private string Course { get; set;}

            private string Subject { get; set;}

            private string University { get; set;}

            private string EmailAdd {get; set; }

            private long PhoneNum {get; set;}
        }
    }
    public class StudenttesT
    {
        public void studentTest()
        {
            Console.WriteLine(StudentsInfo.studentname);
        }
    }
}
