using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SECMAssignmentCode
{
    public partial class CurrentMeetings : Form
    {
        List<string> slot = new List<string>();        

        public CurrentMeetings()
        {
            InitializeComponent();
        }

        private void CurrentMeetings_Load(object sender, EventArgs e)
        { 
            // Need to go though user avaiavlility, if its a b -
            // Loop through rooms 1-5 and if there is a b in the same place display Day x Time x Room x
            String[,] slots = new String[5, 9];

            int time, room;
            int day;

            String[] fileLines = File.ReadAllLines(LoginPage.userName + ".txt");

            for (int y = 0; y < 5; y++) // This for loop goes through the text file and splits all the data up by a comma
            {
                for (int x = 0; x < 9; x++)
                {
                    slots[y, x] = fileLines[y].Split(',')[x]; // After splitting the data it is added into an array in the same x,y
                    if (slots[y, x].ToString() == "b") // This only happens when the user has a meeting booked
                    {

                        // Each time the user is in a meeting this runs
                        // From this i need to add 
                        // Day: Time: Room: 
                        // to the listbox 

                        time = getX(x);
                        day = y;
                        string name = (day.ToString() + time.ToString() + ".txt");
                        room = examineTextFile(day.ToString(), time.ToString());

                        if(room != -1)
                        {
                            string strday = getDay(day);
                            slot.Add(strday + " " + time + ":00 Room " + room);
                        }

                    }

                }
            }

            // Go through rooms 1-5 and check of the y,x has a b
            foreach(string item in slot)
            {
                currentMeetingslbx.Items.Add(item);
            }
           
        }

        /* All Users - used for testing
         29001319,ella,1
        29033577,silvia,0
        29013448,anton,0
        29001234,test,1
        29004321,hello,0
        87654321,test,0
        29009876,test,0
        12345678,hello,1
         */

        int checkContainsUser(string day, string time, string possibleRoom)
        {
            int room = -1;

             string fileName = (day + time + possibleRoom + ".txt");
             FileInfo saveData = new FileInfo(fileName);
             if (saveData.Exists)
             {
                String[] fileLines = File.ReadAllLines(fileName);

                if (fileLines.Contains(LoginPage.userName))
                {
                    room = Convert.ToInt32(fileLines[2]);
                }
            }


            return room;
        }

        int examineTextFile(string day, string time)
        {
            string fileName;
            int room = -1;
            int i = 0;
            do
            {
                room = checkContainsUser(day, time, i.ToString());
                i++;
            } while ((i < 6) && (room == -1));

            return room;
        }

        int getX(int x)
            {
            switch (x)
            {
                case 0:
                    return 9;
                case 1:
                    return 10;
                case 2:
                    return 11;
                case 3:
                    return 12;
                case 4:
                    return 13;
                case 5:
                    return 14;
                case 6:
                    return 15;
                case 7:
                    return 16;
                case 8:
                    return 17;
                default:
                    return 9;
            }
        }

        string getDay(int y)
        {
            switch(y)
            {
                case 0:
                    return "Monday";
                case 1:
                    return "Tuesday";
                case 2:
                    return "Wednesday";
                case 3:
                    return "Thursday";
                case 4:
                    return "Friday";
                default:
                    return "Monday";
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPage f3 = new MenuPage();
            f3.Show();
        }

        private void moreInfobtn_Click(object sender, EventArgs e)
        {
            usersAttendinglbx.Items.Clear();
            usersAttendinglbx.Visible = true;

            string selectedMeeting = currentMeetingslbx.SelectedItem.ToString();
            int day, time, room;
            string fileName;
            day = getFileNameDay(selectedMeeting);
            time = getFileNameTime(selectedMeeting);
            room = getFileNameRoom(selectedMeeting);

            fileName = (day.ToString() + time.ToString() + room.ToString() + ".txt");

            // Put all data into a list
            // Read from lines 3 to .count
            // Put all the strings from that into usersAttendinglbx


            String[] fileLines = File.ReadAllLines(fileName);
            int length = fileLines.Length;
            for(int i = 3; i < length; i++)
            {
                usersAttendinglbx.Items.Add(fileLines[i]);
            }

        }

        int getFileNameDay(string selectedMeeting)
        {
            if(selectedMeeting.Contains("Monday"))
            {
                return 0;
            }
            else if(selectedMeeting.Contains("Tuesday"))
            {
                return 1;
            }
            else if (selectedMeeting.Contains("Wednesday"))
            {
                return 2;
            }
            else if (selectedMeeting.Contains("Thursday"))
            {
                return 3;
            }
            else if (selectedMeeting.Contains("Friday"))
            {
                return 4;
            }
            else
            {
                return 0;
            }

        }

        int getFileNameTime(string selectedMeeting)
        {
            if(selectedMeeting.Contains("9:00"))
            {
                return 9;
            }
            else if(selectedMeeting.Contains("10:00"))
            {
                return 10;
            }
            else if (selectedMeeting.Contains("11:00"))
            {
                return 11;
            }
            else if (selectedMeeting.Contains("12:00"))
            {
                return 12;
            }
            else if (selectedMeeting.Contains("13:00"))
            {
                return 13;
            }
            else if (selectedMeeting.Contains("14:00"))
            {
                return 14;
            }
            else if (selectedMeeting.Contains("15:00"))
            {
                return 15;
            }
            else if (selectedMeeting.Contains("16:00"))
            {
                return 16;
            }
            else if (selectedMeeting.Contains("17:00"))
            {
                return 17;
            }
            else
            {
                return 9;
            }

        }

        int getFileNameRoom(string selectedMeeting)
        {
            if(selectedMeeting.Contains("Room 1"))
            {
                return 1;
            }
            else if(selectedMeeting.Contains("Room 2"))
            {
                return 2;
            }
            else if (selectedMeeting.Contains("Room 3"))
            {
                return 3;
            }
            else if (selectedMeeting.Contains("Room 4"))
            {
                return 4;
            }
            else if (selectedMeeting.Contains("Room 5"))
            {
                return 5;
            }
            else
            {
                return 1;
            }
        }
    }

}
