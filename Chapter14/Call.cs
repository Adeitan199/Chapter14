using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoOnClasses
{
   
    class Call
    {

        public string callDate; 
        public int CallDuration;
        public string StartTime;
            public string EndTime;
        public string CallLine;

        List<Call> calls = new List<Call>();

        public Call(string calldate, int callduration, string starttime, string endtime, string callline)
        {
            callDate = calldate;
            CallDuration = callduration;
            StartTime = starttime;
            EndTime = endtime;
            CallLine = callline;
        }


        public override string ToString()
        {
            return ($"{callDate}\t{CallDuration}\t {StartTime}\t{EndTime}\t{CallLine}");
        }

        

        public static Call ToCall(string str)
        {
            var callstr = str.Split("\t");
            var calldate = callstr[0];
            var callduration = int.Parse(callstr[1]);
            var starttime = callstr[2];
            var endtime = callstr[3];
            var callline = callstr[4];

            return new Call (calldate, callduration, starttime, endtime, callline);
        }


        //Question 17, Write a method that deletes all calls
        void DeleteAll()
        {
            foreach (var call in calls)
            {
                calls.Remove(call);
            }
        }

        public void delete()
        {
            Console.Write("Enter the callline to delete");
            var line = Console.ReadLine();
            
            foreach(var call in calls)
            {
                if (line == call.CallLine)
                {
                    calls.Remove(call);
                }
                     
            }
            Console.WriteLine($"Call with {line} has been successfully deleted from call list");
            
        }


        //Question 18 Total Amount of calls in Archive

        public int Totalcall(int a)
        {
            a = 50;
            int amount = 0;
            foreach(var time in calls)
            {
                amount =+CallDuration;
            }
            return amount;
        }


        //Question 19 GSMCallHistoryTest

        public void GSMCallHistroyTest()
        {
            Call call1 = new Call("23/12/21", 5, "09:31", "09:36", "08032333435");
            Call call2 = new Call("23/12/21", 3, "09:32", "09:35", "08034567890");
            Call call3 = new Call("23/12/21", 6, "09:33", "09:39", "09093949505");

            //Total Caost of all calls
            double Totalcost = 0;
            foreach(var call in calls)
            {
                double cost = 0.37 * CallDuration;
                Totalcost += cost;
            }
            Console.WriteLine(Totalcost);


            void LongestCall()
            {
                var Longest = 0;
               
                foreach(var call in calls)
                {
                    if (call.CallDuration > Longest)
                    {
                        int temLongest = call.CallDuration;
                        Longest = temLongest;
                    }
                    calls.Remove(call);
                }
               

            }


        }
    }
}
