using System;
using System.Collections.Generic;

namespace StudentInfoOnClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  // Console.WriteLine("Hello World!");


               StudentsInfo student1 = new StudentsInfo("Ade", "Olaitan", "CLA");

               //student1.FirstName = "Ade";

               // Console.WriteLine(student1.FirstName + student1.Surname);


               Students rectangle = new Students();

               MobilePhone Phone1 = new MobilePhone("Nokia 1500", "Nokia china", 50000, "Akin");

               Console.WriteLine(Phone1.model);

   */
            //List<string> name = new List<string>();
           MobilePhone phone1 = new MobilePhone("gh", "ghj", 200, "fjhjk");

            /*name.Add("haleem");
            name.Add("ayo");
            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine(name[i]);
            }*/

            // Console.WriteLine(phone1);
           
            Palindrome();
            
        }

        public static  bool Palindrome()
        {
            bool isPalindrome = false;
            string word = "12321";

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] == word[word.Length - 1 - i])
                {
                    isPalindrome = true;
                }
            }
            Console.WriteLine(isPalindrome);
            return isPalindrome;
        }
    }
}
