
public bool Generate ( Course course[ ], int n )
{

	bool noConflicts = true;
	
	foreach ( Section i in course[ n ].section )	// for each section in course
	{
		noConflicts = true; // start by assuming that there will not be a conflict
		
		foreach ( timeSlot j in course[ n ].section[ i ].timeSlot )
		{
			if ( time[ course[ n ].section[ i ].timeslot[ j ].day ][ course[ n ].section[ i ].timeslot[ j ].startTime ] ) // if the time's taken already
			{
				noConflicts = false;		//then there's a conflict (lol)
				break;						//breaks the nested loop, goes on to next section.
			}								//note that if this is the last section, noConflicts will not be reset to true.
		}			// if we go through every timeslot for the course and nothing's taken, noConflicts will be true when exiting.
		
		if ( noConflicts )	// if we found a section that works
		{
			foreach ( timeSlot j in course.section[i].timeSlot )	//occupy all the timeslots for that section
			{
				time[ course.section[ i ].timeslot[ j ].day ][ course.section[ i ].timeslot[ j ].startTime ] = true;
			}
			
			if ( n == course.Length || Generate( course, n + 1 ) )	//recur. If it's the last in the array or we get true back from one level down, pass true back up.
				return true;
			else 	//if generating the next course fails
			{
				foreach ( timeSlot j in course.section[i].timeSlot )		//unoccupy all the timeslots we took earlier
				{
					time[ course.section[ i ].timeslot[ j ].day ][ course.section[ i ].timeslot[ j ].startTime ] = false;
				}
			}//section will now increment
		}
	}
	
	if ( !noConflicts )	// if the last available section didn't work, we need to change something from the previous course. Pass false back up.s
		return false;
	
}
