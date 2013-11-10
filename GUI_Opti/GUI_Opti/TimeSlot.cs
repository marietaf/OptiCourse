using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class TimeSlot
    {
        public TimeSlot()
        {
            int type = 0;
            day = 0;
            instructor = "";
            startTime = 0;
            length = 0;
            location = "";
        }


        enum WeekDay { M, T, W, Th, F, S, SU };
        int day;
        public int startTime;        //indexed by half hour from 0800 please
        int length;                //in minutes, please. no.
        string location;
        private string instructor;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Instructor
            {
                get { return instructor; }
                set { instructor = value; }
            }
    }

