class TimeSlot
{
    public TimeSlot()
	{
		type = 0;
		day = 0;
		instructor = "";
		startTime = 0;
		length = 0;
		location = 0;
	}
	
	
    enum WeekDay { M, T, W, Th, F, S, SU };
    int day;
    int startTime;	//indexed by half hour from 0800 please
    int length;		//in minutes, please
    string location;
    
    public int Day
    {
        get{ return day; }
        set{ day = value; }
    }
    
    public int StartTime
    {
        get{ return startTime; }
        set{ startTime = value; }
    }
    
    public int Length
    {
        get{ return length; }
        set{ length = value; }
    }
    
    public int Location
    {
        get{ return location; }
        set{ location = value; }
    }
}
