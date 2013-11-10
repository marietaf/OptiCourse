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
    private int num;
	private string instructor;
    
	int Type
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
    
    int Number
    {
        get{ return num; }
        set{ num = value; }
    }
    
    string Instructor
    {
        get{ return instructor; }
        set{ instructor = value; }
    }
    
    TimeSlot[] TimeSlots
    {
        get{ return timeSlot; }
        set{ timeSlot = value; }
    }
    
    public void InitializeTimeSlots( int numOfTimeSlots )
    {
        timeSlots = new TimeSlot[numOfTimeSlots];
    }
}