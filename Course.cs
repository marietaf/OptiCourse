using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Section;
using TimeSlot;

class Course
{
    //Declares an array of undefined length which will be determined later
    Section[] sections;

    public Course(string fileName)
    {
        StreamReader sr = new StreamReader( fileName + ".txt" );
        string currentLine = sr.ReadLine();

        int sectionCount = 0;
        // Counts the number of sections in the file
        while( !sr.EndOfStream )
        {
            if( currentLine.Contains( "Section" ) )
                sectionCount++; 
        }
        sections = new Section[ sectionCount ];
        // Go back to beginning of stream
        sr.BaseStream.Position = 0;
        sr.DiscardBufferedData();
        
        // Change input into data for each section
        while( !sr.EndOfStream ){
            foreach( Section section in sections )
            {
                // Go to the first instance of a section (001)
                while( !( currentLine[0] >= 0 ) || !( currentLine[0] <= 9 ) )
                    currentLine = sr.ReadLine();
                
                // Get section number and section type
                section.Num = Convert.ToInt32(currentLine.Substring(0, 3));
                section.Type = currentLine.Substring( 4, 6 );
                
                // Go to the heading of time slots
                while( currentLine[0] != 'D' )
                    currentLine = sr.ReadLine();
                // Go to first line of time slots
                currentLine = sr.ReadLine();
                
                // Make array list with variable length to get the time slots
                List <TimeSlot> timeSlotList = new List<TimeSlot>();
                // Go through time slots and add them to the list
                while( !String.IsNullOrWhiteSpace(currentLine) )
                {
                    int cursor = 0;
                    int additionCount = 0;
                    // Finds the day(s) of the section
                    while( currentLine[cursor] != ' ' )
                    {
                        TimeSlot tempTimeSlot = new TimeSlot();
                        if( currentLine[cursor] == 'M' )
                            tempTimeSlot.Day = 0;
                        else if( currentLine[cursor] == 'T' && currentLine[cursor+1] != 'h' )
                            tempTimeSlot.Day = 1;
                        else if( currentLine[cursor] == 'W' )
                            tempTimeSlot.Day = 2;
                        else if( currentLine[cursor] == 'T' && currentLine[cursor+1] == 'h' )
                            tempTimeSlot.Day = 3;
                        else if( currentLine[cursor] == 'F' )
                            tempTimeSlot.Day = 4;
                        else if( currentLine[cursor] == 'S' )
                            tempTimeSlot.Day = 5;
                        if( currentLine[cursor] != 'h' )
                        {
                            timeSlotList.Add( tempTimeSlot );
                            additionCount++;
                        }
                        cursor++;
                    }
                    // Go to where the time stamp starts
                    cursor++;
                    
                    string timeStamp = currentLine.Substring( cursor, currentLine.Length-1 );
                    
                    // Update the length of the course in minutes based on the timestamp
                    
                    // Check whether the hour is represented by one or two numbers
                    int begHr = 2, endHr = 2;
                    if( timeStamp[1] == ':' && timeStamp[11] == ':' )
                        begHr = 1;
                    else if( timeStamp[1] != ':' && timeStamp[11] == ':' )
                        endHr = 1;
                    else if( timeStamp[1] == ':' && timeStamp[10] == ':' )
                    {   
                        begHr = 1;
                        endHr = 1;
                    }
                        
                    int startTime = Convert.ToInt32( timeStamp.Substring( 0, begHr ) ) * 60;
                    startTime += Convert.ToInt32( timeStamp.Substring( begHr+1, 2 ) );
                        
                    int endTime = Convert.ToInt32( timeStamp.Substring( begHr+8, endHr ) ) * 60;
                    endTime += Convert.ToInt32( timeStamp.Substring( begHr+endHr+9, 2 ) );
                        
                    if( timeStamp[begHr+3] == 'P' )
                        startTime += 12*60;
                    if( timeStamp[begHr+endHr+11] == 'P' )
                        endTime += 12*60;
                            
                    int length = endTime - startTime;
                    
                    // Find actual start time after 8am on half hour intervals
                    startTime = (startTime - 8*60)/30;
                    // Update the location of the course
                    string location = currentLine;
                    currentLine = sr.ReadLine();
                    // Update the instructor for the course 
                    string instructor = currentLine;
                    currentLine = sr.ReadLine();
                    // Skip over the dates -- unimportant 
                    currentLine = sr.ReadLine();
                    
                    // Update other fields of the latest additions to the List
                    for( int i = 0; i < additionCount; i++ )
                    {
                        int index = timeSlotList.Count-i;
                        timeSlotList[index].Length = length;
                        timeSlotList[index].Location = location;
                        timeSlotList[index].StartTime = startTime;
                        timeSlotList[index].Instructor = instructor;
                    }
                    
                    currentLine = sr.ReadLine();
                }
                
                // Create an array based on the List
                TimeSlot [] timeSlots = new TimeSlot[timeSlotList.Count()];
                for( int i = 0; i < timeSlotList.Count; i++ )
                {
                    timeSlots[i] = timeSlotList[i];
                }
                
                // Set the time slot array to the section
                section.TimeSlots = timeSlots;
            }
        }
    }
}
