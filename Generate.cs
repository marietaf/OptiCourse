public bool Generate ( Course course[ ], int n )
{

	bool noConflicts = true;
	int ctr = 0;
	
	foreach ( Section i in course[ n ].section )	// for each section in course
	{
		ctr++;
		noConflicts = true; // start by assuming that there will not be a conflict
		
		foreach ( timeSlot j in i.timeSlot )
		{
			if ( 
				!TimeFree
				( 
					j.day, 
					j.startTime, 
					j.length 
				) 
			) // if the time's taken already
			{
				noConflicts = false;		//then there's a conflict (lol)
				break;						//breaks the nested loop, goes on to next section.
			}								//note that if this is the last section, noConflicts will not be reset to true.
		}			// if we go through every timeSlot for the course and nothing's taken, noConflicts will be true when exiting.
		
		if ( noConflicts )	// if we found a section that works
		{
			course[n].activeSection = ctr;
			
			foreach ( timeSlot j in i.timeSlot )	//occupy all the timeSlots for that section
			{
				OccupyTime
				( 
					j.day, 
					j.startTime, 
					j.length 
				) 
			}
			
			if ( n == course.Length || Generate( course, n + 1 ) )	//recur. If it's the last in the array or we get true back from one level down, pass true back up.
				return true;
			else 	//if generating the next course fails
			{
				foreach ( timeSlot j in i.timeSlot )		//unoccupy all the timeSlots we took earlier
				{
					time[ j.day ][ j.startTime ] = false;
				}
			}//section will now increment
		}
	}
	
	if ( !noConflicts )	// if the last available section didn't work, we need to change something from the previous course. Pass false back up.s
		course[n].activeSection = 0;
		return false;
	
}


public bool TimeFree( int day, int startTime, int len )
{
	for ( int i = 0; i < len%30; i++ )
	{
		if ( time[ day ][ startTime + i ] )
			return false
	}
	
	return true;
}

public void OccupyTime ( int day, int startTime, int len )
{
	for ( int i = 0; i < len%30; i++ )
	{
		time[ day ][ startTime + i ] = true;
	}
}
