using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Schedule
    {
        // Arrays for the schedule
        //Course timeSlotArray[] = new Course[7*28];
        bool[,] scheduleAvail;
        int courseCount;

        public Schedule()
        {
            // Create time slots - 7 days with 28 slots per day
            scheduleAvail = new bool[7, 28];
            courseCount = 0;

            // Assume all time slots are free
            for (int i = 0; i < scheduleAvail.GetLength(0); i++)
            {
                for (int j = 0; j < scheduleAvail.GetLength(1); j++)
                {
                    scheduleAvail[i, j] = false;
                }
            }
        }

        public void ChangeDayToBusy(int day)
        {
            for (int i = 0; i < 28; i++)
            {
                scheduleAvail[day,i] = true;
            }
        }

        public void NoNightClass(int time)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = time; j < 28; j++)
                {
                    scheduleAvail[i,j] = true;
                }
            }
        }

        public void NoEarlyClass(int time)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = time; j < 28; j++)
                {
                    scheduleAvail[i, j] = false;
                }
            }
        }

        public Schedule(Course course1, Course course2, Course course3, Course course4, Course course5)
        {
            // Create time slots - 7 days with 28 slots per day
            scheduleAvail = new bool[7, 28];
            courseCount = 5;

            // Assume all time slots are free
            for (int i = 0; i < scheduleAvail.GetLength(0); i++)
            {
                for (int j = 0; j < scheduleAvail.GetLength(1); j++)
                {
                    scheduleAvail[i, j] = false;
                }
            }

            // Add in the courses to the first available times - TREVOR

        }



        public void AddCourse()
        {

        }

        public void RemoveCourse()
        {

        }
    }
} 
