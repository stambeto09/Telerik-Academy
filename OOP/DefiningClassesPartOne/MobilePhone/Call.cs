using System;
using System.Collections.Generic;

namespace Phone
{
    public class Call
    {
        //Fields
        private DateTime date;
        private UInt32 time;
        private string dialedPhoneNumber;
        private UInt32 seconds;
        private List<Call> callHistory=new List<Call>();
        
        //Properties
       public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }
           public DateTime Date
        {
            get
            { return this.date.Date; }

            set
            {
                this.date = value;
            }
        }

        public uint Time
        {
            get
            { return this.time; }

            set
            {
                this.time = value;
            }
        }

        public string DialedPhoneNumber
        {
            get
            { return this.dialedPhoneNumber; }

            set
            {
                this.dialedPhoneNumber = value;
            }
        }
        public uint Seconds
        {
            get
            { return this.seconds; }

            set
            {
                this.seconds = value;
            }
        }

        //Constructors
        public Call(DateTime date)
        {
            this.DialedPhoneNumber = dialedPhoneNumber;
        }
        public Call(DateTime date,string dialedPhoneNumber):this(date)
        {
            this.DialedPhoneNumber=dialedPhoneNumber;
        }
        public Call(DateTime date, string dialedPhoneNumber,UInt32 time):this(date,dialedPhoneNumber)
        {
            this.Time = time;
        }
        public Call(DateTime date, string dialedPhoneNumber,UInt32 time,UInt32 seconds):this(date,dialedPhoneNumber,time)
        {
            this.Seconds = seconds;
        }
        public void DisplayCalls()
        {
            for (int index = 0; index < CallHistory.Count; index++)
            {
                Console.WriteLine(callHistory[index]);
            }
        }
    }
}
