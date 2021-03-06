﻿using System;
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
    public partial class BookRoom : Form
    {
        string[,] room1 = new string[5, 9];
        string[,] room2 = new string[5, 9];
        string[,] room3 = new string[5, 9];
        string[,] room4 = new string[5, 9];
        string[,] room5 = new string[5, 9];
        string dayOfMeeting;
        int y, x, timeOfMeeting;
        List<User> usersInMeeting = new List<User>();


        // WHAT I NEED TO DO:

            // When a meeting is booked change each users avaiabiliy (the textfile with exclusions and preferences)
            // Change that slot to a b for booked, on the arrange meeting form add each slot that is an e/b
            // to the exclusions because they cannot be used
            // Make button on menu saying "View Meetings" to show all teh time slots and room locations that taht user is booked in a meeting for
            // If they want to exit taht meeting then just ask if they want to exclude/prefer/don't mind and change their availability

        public BookRoom(List<User> meetingUsers)
        {
            usersInMeeting = meetingUsers;
            InitializeComponent();
        }

        private void BookRoom_Load(object sender, EventArgs e)
        { 

            foreach (string item in ArrangeMeeting.allAvailableList)
            {
                availablelbx.Items.Add(item);
            }

            foreach(string item in ArrangeMeeting.prefList)
            {
                preflbx.Items.Add(item);
            }


            // TODO: Load each room's txt into a 9x5 grid, after user selects a slot and presses the button a list of rooms that are avaivale at that time are shown
            // User needs to select a room and then press the button, this will change the text file by changing the "f" for free to "b" for booked


            // Future task: add a way to add rooms to the system (mod access only)

            for(int i = 1; i < 6; i++)
            {
                String[] fileLines = File.ReadAllLines("room" + i + ".txt");

                for (int y = 0; y < 5; y++) // This for loop goes through the text file and splits all the data up by a comma
                {
                    for (int x = 0; x < 9; x++)
                    {
                        switch(i)
                        {
                            case 1:
                                room1[y, x] = fileLines[y].Split(',')[x];
                                break;
                            case 2:
                                room2[y, x] = fileLines[y].Split(',')[x];
                                break;
                            case 3:
                                room3[y, x] = fileLines[y].Split(',')[x];
                                break;
                            case 4:
                                room4[y, x] = fileLines[y].Split(',')[x];
                                break;
                            case 5:
                                room5[y, x] = fileLines[y].Split(',')[x];
                                break;
                        }
                    }
                }
            }
            





        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            roomlbx.Items.Clear();

            string slot = availablelbx.SelectedItem.ToString();

            y = getY(slot);
            x = getX(slot);


            addIntoList(room1, "Room 1", y, x);
            addIntoList(room2, "Room 2", y, x);
            addIntoList(room3, "Room 3", y, x);
            addIntoList(room4, "Room 4", y, x);
            addIntoList(room5, "Room 5", y, x);








        }

        void addIntoList(string[,] room, string roomName, int y, int x)
        {
            if (room[y, x] == "f")
            {
                roomlbx.Items.Add(roomName);
            }
        }

        int getY(string slot)
        {
            int y = 0;

            if (slot.Contains("Monday"))
            {
                dayOfMeeting = "Monday";
                y = 0;
            }
            else if (slot.Contains("Tuesday"))
            {
                dayOfMeeting = "Tuesday";
                y = 1;
            }
            else if (slot.Contains("Wednesday"))
            {
                dayOfMeeting = "Wednesday";
                y = 2;
            }
            else if (slot.Contains("Thursday"))
            {
                dayOfMeeting = "Thursday";
                y = 3;
            }
            else if (slot.Contains("Friday"))
            {
                dayOfMeeting = "Friday";
                y = 4;
            }

            return y;
        }

        int getX(string slot)
        {
            int x = 0;

            if(slot.Contains("9am"))
            {
                timeOfMeeting = 9;
                x = 0;
            }
            else if (slot.Contains("10am"))
            {
                timeOfMeeting = 10;
                x = 1;
            }
            else if (slot.Contains("11am"))
            {
                timeOfMeeting = 11;
                x = 2;
            }
            else if (slot.Contains("12pm"))
            {
                timeOfMeeting = 12;
                x = 3;
            }
            else if (slot.Contains("1pm"))
            {
                timeOfMeeting = 13;
                x = 4;
            }
            else if ((slot.Contains("2pm"))&&(!slot.Contains("12pm")))
            {
                timeOfMeeting = 14;
                x = 5;
            }
            else if (slot.Contains("3pm"))
            {
                timeOfMeeting = 15;
                x = 6;
            }
            else if (slot.Contains("4pm"))
            {
                timeOfMeeting = 16;
                x = 7;
            }
            else if (slot.Contains("5pm"))
            {
                timeOfMeeting = 17;
                x = 8;
            }


            return x;
        }

        private void availablelbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomlbx.Items.Clear();
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            // * = prefer
            // Change the f to a b in the room array
            // Either delete and make a new file for that room
            // OR
            // Edit that line of the textfile*


            string roomBooked = roomlbx.SelectedItem.ToString();

            Meeting meeting = new Meeting(dayOfMeeting, timeOfMeeting);



            switch (roomBooked)
            {
                case "Room 1":
                    editRoomTextFile(room1, "room1");
                    meeting.setRoom(1);
                    break;
                case "Room 2":
                    editRoomTextFile(room2, "room2");
                    meeting.setRoom(2);
                    break;
                case "Room 3":
                    editRoomTextFile(room3, "room3");
                    meeting.setRoom(3);
                    break;
                case "Room 4":
                    editRoomTextFile(room4, "room4");
                    meeting.setRoom(4);
                    break;
                case "Room 5":
                    editRoomTextFile(room5, "room5");
                    meeting.setRoom(5);
                    break;
            }

            
           foreach(User user in usersInMeeting)
            {
                int x, y;
                meeting.addUser(user);
                y = meeting.getDayInt();
                x = correctX(meeting.getTime());
                editUsersFiles(user.getUserName(), y, x);

            }

            makeMeetingtxt(meeting);

            this.Hide();
            MenuPage f1 = new MenuPage();
            f1.Show();
        }

        int correctX(int x)
        {
            switch(x)
            {
                case 9:
                    return 0;
                case 10:
                    return 1;
                case 11:
                    return 2;
                case 12:
                    return 3;
                case 13:
                    return 4;
                case 14:
                    return 5;
                case 15:
                    return 6;
                case 16:
                    return 7;
                case 17:
                    return 8;
                default:
                    return 0;

            }
        }

        void editUsersFiles(string filename, int ySlot, int xSlot)
        {
            // Put all info into a 4x7 array
            // Change the specific y,x to "b"
            // Put all info into a new textfile

            string fileName = filename + ".txt";

            string[,] userAvailable = new string[5, 9];

            String[] fileLines = File.ReadAllLines(fileName);

            for (int y = 0; y < 5; y++)
            {
                for(int x = 0; x < 9; x++)
                {
                    userAvailable[y, x] = fileLines[y].Split(',')[x];
                }
            }

            userAvailable[ySlot, xSlot] = "b";


           FileInfo saveData = new FileInfo(fileName);

            if (saveData.Exists)
            {

                File.Delete(fileName); // If it already exists it deletes the text file

            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true)) // Creates a new text file with teh desired file path name
            {
                for (int y = 0; y < 5; y++) // Loops through all 45 combo boxes
                {
                    for (int x = 0; x < 9; x++)
                    {
                        if (x < 8) // The first 7 combo boxes on a line because we don't want a comma at the end of each line
                        {
                            if(userAvailable[y,x] == "p")
                            {
                                file.Write("p,");
                            }
                            else if(userAvailable[y, x] == "e")
                            {
                                file.Write("e,");
                            }
                            else if(userAvailable[y, x] == "d")
                            {
                                file.Write("d,");
                            }
                            else if (userAvailable[y, x] == "b")
                            {
                                file.Write("b,");
                            }
                        }
                        else
                        {
                            if (userAvailable[y, x] == "p")
                            {
                                file.WriteLine("p");
                            }
                            else if (userAvailable[y, x] == "e")
                            {
                                file.WriteLine("e");
                            }
                            else if (userAvailable[y, x] == "d")
                            {
                                file.WriteLine("d");
                            }
                            else if (userAvailable[y, x] == "b")
                            {
                                file.WriteLine("b");
                            }
                        }
                    }
                }
            }

        }

        void editRoomTextFile(string[,] room, string fileN)
        {
            room[y, x] = "b";

            string fileName = fileN + ".txt";

            FileInfo saveData = new FileInfo(fileName);

            if (saveData.Exists)
            {

                File.Delete(fileName); // If it already exists it deletes the text file

            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true)) // Creates a new text file with teh desired file path name
            {
            for (int y = 0; y < 5; y++) // Loops through all 45 combo boxes
            {
                for (int x = 0; x < 9; x++)
                {
                    if (x < 8) // The first 7 combo boxes on a line because we don't want a comma at the end of each line
                    {

                        if (room[y, x].Contains("f")) // If the combo box has Prefer selected it will as a "p" to the text file
                        {
                            file.Write("f,");
                        }
                        else if (room[y, x].Contains("b")) // If the combo box has Exclude selected it will as a "e" to the text file
                        {
                            file.Write("b,");
                        }

                    }
                    else if (x == 8) // Exactly the same as the if statement above but for the last ekement in a line so there is no "," at the end of each line
                    {
                            if (room[y, x].Contains("f")) // If the combo box has Prefer selected it will as a "p" to the text file
                            {
                                file.WriteLine("f");
                            }
                            else if (room[y, x].Contains("b")) // If the combo box has Exclude selected it will as a "e" to the text file
                            {
                                file.WriteLine("b");
                            }

                        }

                }

            }


        }
        }

        void makeMeetingtxt(Meeting meeting)
        {
            string fileName;

            fileName = (meeting.getDayInt().ToString() + meeting.getTime().ToString() + meeting.getRoom().ToString() + ".txt"); 

            FileInfo saveData = new FileInfo(fileName);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true)) // Creates a new text file with teh desired file path name
            {
                file.WriteLine(meeting.getDayInt());
                file.WriteLine(meeting.getTime());
                file.WriteLine(meeting.getRoom());
                foreach(User user in usersInMeeting)
                {
                    file.WriteLine(user.getUserName());
                }

            }




            }

    }
}
