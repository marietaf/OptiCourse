using System;

class Schedule
{
    // Arrays for the schedule
    //Course timeSlotArray[] = new Course[7*28];
    public bool [,] scheduleAvail;
    int courseCount;
    
    public Schedule()
    {
        // Create time slots - 7 days with 28 slots per day
        scheduleAvail = new bool[7, 28];
        courseCount = 0;
        
        // Assume all time slots are free
        foreach( bool slot in scheduleAvail )
        {
            slot = false;
        }
    }
    
    public Schedule( Course course1, Course course2, Course course3, Course course4, Course course5 )
    {
        // Create time slots - 7 days with 28 slots per day
        scheduleAvail = new bool[7, 28];
        courseCount = 5;
        
        // Assume all time slots are free
        foreach( bool slot in scheduleAvail )
        {
            slot = false;
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
