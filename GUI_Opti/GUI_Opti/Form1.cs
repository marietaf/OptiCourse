using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void programStart_Click(object sender, EventArgs e)
        {
            OleDbConnection theConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Piew Piew Piew\\Documents\\Visual Studio 2010\\Excel\\schedule.xlsx;Extended Properties=;Extended Properties=Excel 12.0;");
            theConnection.Open();
            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", theConnection);
            DataSet theDS = new DataSet();
            System.Data.DataTable dt = new System.Data.DataTable();
            theDataAdapter.Fill(dt);
            this.dataGridView1.DataSource = dt.DefaultView;
        }

        public void NoClassesOnDay() 
        {
            Schedule freeDays = new Schedule();
           
            if (Mondays.Checked && Tuesdays.Checked && Wednesdays.Checked && Thursdays.Checked && Fridays.Checked && Saturdays.Checked)
            {
                for (int i = 0; i < 6; i++)
                {
                    freeDays.ChangeDayToBusy(i);
                }
            }
            else if (Mondays.Checked && Tuesdays.Checked && Wednesdays.Checked && Thursdays.Checked && Fridays.Checked)
            {
                for (int i = 0; i < 5; i++)
                {
                    freeDays.ChangeDayToBusy(i);
                }

            }
            else if (Mondays.Checked && Tuesdays.Checked && Wednesdays.Checked && Thursdays.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    freeDays.ChangeDayToBusy(i);
                }
            }
            else if (Mondays.Checked && Tuesdays.Checked && Wednesdays.Checked)
            {
                for (int i = 0; i < 3; i++)
                {
                    freeDays.ChangeDayToBusy(i);
                }
            }
            else if (Mondays.Checked && Tuesdays.Checked)
            {
                for (int i = 0; i < 2; i++)
                {
                    freeDays.ChangeDayToBusy(i);
                }
            }
            else if (Mondays.Checked)
            {
                freeDays.ChangeDayToBusy(0);
            }
            return;

        }

        public void NightOrEarly()
        {
            Schedule noNight = new Schedule();
            Schedule noEarly = new Schedule();

             if (nightClass.Checked)
            {
                noNight.NoNightClass(21);
            }

            if (earlyClass.Checked)
            {
                noEarly.NoEarlyClass(4);
            }
            return;
         
        }

        private void ReGen_Click(object sender, EventArgs e)
        {
            
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            
                    using (StreamWriter sw1 = new StreamWriter("course1.txt"))
                    {
                        if (course1Box.Text != null)
                        {
                            sw1.WriteLine(course1Box.Text);
                            sw1.Close();
                        }
                        else
                        {
                            sw1.WriteLine(" ");
                            sw1.Close();
                        }
                    }
                    
                    using (StreamWriter sw2 = new StreamWriter("course2.txt"))
                    {
                        if (course2Box.Text != null)
                        {
                            sw2.WriteLine(course2Box.Text);
                            sw2.Close();
                        }
                        else
                        {
                            sw2.WriteLine(" ");
                            sw2.Close();
                        }
                    }
               

                    using (StreamWriter sw3 = new StreamWriter("course3.txt"))
                    {
                        if (course3Box.Text != null)
                        {
                            sw3.WriteLine(course3Box.Text);
                            sw3.Close();
                        }
                        else
                        {
                            sw3.WriteLine(" ");
                            sw3.Close();
                        }
                    }

                    using (StreamWriter sw4 = new StreamWriter("course4.txt"))
                    {
                        if (course4Box.Text != null)
                        {
                            sw4.WriteLine(course4Box.Text);
                            sw4.Close();
                        }
                        else
                        {
                            sw4.WriteLine(" ");
                            sw4.Close();
                        }
                    }

                    using (StreamWriter sw5 = new StreamWriter("course5.txt"))
                    {
                        if (course5Box.Text != null)
                        {
                            sw5.WriteLine(course5Box.Text);
                            sw5.Close();
                        }
                        else
                        {
                            sw5.WriteLine(" ");
                            sw5.Close();
                        }
                    }

                    
                    using (StreamWriter sw6 = new StreamWriter("course6.txt"))
                    {
                        if (course6Box.Text != null)
                        {
                            sw6.WriteLine(course5Box.Text);
                            sw6.Close();
                        }
                        else
                        {
                            sw6.WriteLine(" ");
                            sw6.Close();
                        }
                    }
                    string[][] dataArray = new string[7][];
                     Course[] courseArray = new Course[6];
                courseArray[0] = new Course("course1.txt");Console.WriteLine("Test");
                courseArray[1] = new Course("course2.txt");
                courseArray[2] = new Course("course3.txt");
                courseArray[3] = new Course("course4.txt");
                courseArray[4] = new Course("course5.txt");
                courseArray[5] = new Course("course6.txt");
                for (int day = 0; day < dataArray.GetLength(0); day++) // row
                {
                    string[] temp;
                    for (int course = 0; course < courseArray.Length; course++) // column
                    {
                        TimeSlot[] timeslots = courseArray[course].sections[courseArray[course].activeSection].TimeSlots;
                        temp = new string[28];
                        foreach (TimeSlot timeslot in timeslots)
                        {
                            if (timeslot.Day == day)
                                temp[timeslot.StartTime] = timeslot.Instructor + "\r\n" + timeslot.Location + "\r\n" + timeslot.Day;
                        }
                        dataArray[day] = temp;
                    }
                }
                string delimiter = ",";
                int length = dataArray.GetLength(0);
                StringBuilder sb = new StringBuilder();
                for (int index = 0; index < length; index++)
                    sb.AppendLine(string.Join(delimiter, dataArray[index]));

                string filePath = @"C:\\Users\\Piew Piew Piew\\Documents\\Visual Studio 2010\\Excel\\output.csv";

                File.WriteAllText(filePath, sb.ToString());

                var filename = @"C:\Users\Piew Piew Piew\Documents\Visual Studio 2010\Excel\output.csv";
                var connString = string.Format(
@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0};Extended Properties=""Text;HDR=YES;FMT=Delimited""",
                    Path.GetDirectoryName(filename)
                );
                using (var conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    var query = "SELECT * FROM [" + Path.GetFileName(filename) + "]";
                    using (var adapter = new OleDbDataAdapter(query, conn))
                    {
                        var ds = new DataSet("CSV File");
                        adapter.Fill(ds);
                    }
                }
            }
        
        

        private void ReGen_Click_1(object sender, EventArgs e)
        {

        }

    }
}

