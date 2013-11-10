class Section
{
	enum Type { LECTURE, TUTORIAL, LAB };
	
	public Section ()
	{
		type = 0;
		instructor = "";
	}
	
	public TimeSlot[] timeSlot;
	private int type;
	private string instructor;
	
	
	public int Type
    {
        get{ return sectionType; }
        set
        { 
            if( value.ToLower() == "lec" )
                type = Type.LECTURE;
            else if( value.ToLower() == "tut" )
                type = Type.TUTORIAL;
            else if( value.ToLower() == "lab" )
                type = Type.LAB;
        }
    }
    
    public string Instructor
    {
        get{ return instructor; }
        set{ instructor = value; }
    }
}

class TimeSlot
{
    public TimeSlot()
	{
		num = 0;
		type = 0;
		day = 0;
		instructor = "";
		startTime = 0;
		length = 0;
		location = 0;
	}
	
	
    enum WeekDay { M, T, W, Th, F, S, SU };
    int num;
    int day;
    int startTime;	//indexed by half hour from 0800 please
    int length;		//in minutes, please
    string location;
    
    int Number
    {
        get{ return num; }
        set{ num = value; }
    }
    
    
    
    public int Day
    {
        get{ return day; }
        set{ day = value; }
    }
    
    public int Time
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
