using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Section
{
    // enum Type { LECTURE, TUTORIAL, LAB };

    public Section()
    {
        type = "";
    }

    public TimeSlot[] timeSlot;
    private string type;
    private int num;

    public string Type
    {
        get { return type; }
        set
        {
            type = value.ToLower();
        }
    }

    public int Num
    {
        get { return num; }
        set { num = value; }
    }

    public TimeSlot[] TimeSlots
    {
        get { return timeSlot; }
        set { timeSlot = value; }
    }

    public void InitializeTimeSlots(int numOfTimeSlots)
    {
        TimeSlot[] timeSlots = new TimeSlot[numOfTimeSlots];
    }
}
