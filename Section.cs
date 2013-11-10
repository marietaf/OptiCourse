class Section
{
    enum Type { LECTURE, TUTORIAL, LAB };
    enum WeekDay { MON, TUE, WED, THU, FRI, SAT, SUN };
    int num;
    int type;
    string instructor;
    int day;
    // add time
    int length;
    string location;
    
    int Number
    {
        get{ return num; }
        set{ num = value; }
    }
    
    int Type
    {
        get{ return sectionType; }
        set
        { 
            if( value.ToLower() == "lecture" )
                type = Type.LECTURE;
            else if( value.ToLower() == "tutorial" )
                type = Type.TUTORIAL;
            else if( value.ToLower() == "lab" )
                type = Type.LAB;
        }
    }
    
    string Instructor
    {
        get{ return instructor; }
        set{ instructor = value; }
    }
    
    int Day
    {
        get{ return day; }
        set{ day = value; }
    }
    
    ??? Time
    {
        get{ return time; }
        set{ time = value; }
    }
    
    int length
    {
        get{ return length; }
        set{ length = value; }
    }
    
    int Location
    {
        get{ return location; }
        set{ location = value; }
    }
}
