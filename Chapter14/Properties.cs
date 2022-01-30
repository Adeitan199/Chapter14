using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoOnClasses
{
    public class Students
    {

        private string FirstName;

        private string Surname;

        private string Course;

        private string Subject;

        private string University;

        private string EmailAdd;

        private long PhoneNum;

        

        public string GetFirstName()
        {
            return FirstName;
        }

        public string SetFirstName()
        {
            this.FirstName = FirstName;
            return FirstName;
        }
    }

}

