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
    public partial class ArrangeMeeting : Form
    {
        List<string> meetingUsers = new List<string>();
        List<string> prefList = new List<string>();
        List<string> exList = new List<string>();
        List<string> allAvailableList = new List<string>();


        public ArrangeMeeting()
        {
            InitializeComponent();
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            string userName = namestb.Text;
            if (namestb.Text == "")
            {
                MessageBox.Show("You need to enter a username");
            }
            else
            {
                if (nameslbx.Items.Contains(userName))
                {
                    MessageBox.Show("You have already added this user");
                }
                else
                {
                    if (LoginPage.userNames.Contains(namestb.Text))
                    {
                        nameslbx.Items.Add(namestb.Text);
                        meetingUsers.Add(userName);
                        savebtn.Show();
                    }
                    else
                    {
                        MessageBox.Show("This user does not exist");
                    }
                }
            }
            namestb.Text = "";
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
            availablelbx.Show();
            selectbtn.Show();

            string userName;

            MessageBox.Show("A list of all the preferenes and exclusions will appear. The times in the exlusions have been taken out of the preferences list so it makes that slot unavailable.");
    
            // For each item in names listbox
            // Go through each user, go through their textfile with their pref/exclusions
            // Add each pref to a list and each exclude to a list (not duplicating)
            // At the end take out the exlusions from the pref and display all in the listboxes
            //C:\Users\ellap\OneDrive - Sheffield Hallam University\SECMAssignmentCode\SECMAssignmentCode\bin\Debug

            // Save the co-ordinate of p or e:

            // If on first line = monday 
            // If on first column = 9am

            String[,] slots = new String[5,9];

            for (int i = 0; i <= nameslbx.Items.Count - 1; i++)
            {
                userName = nameslbx.Items[i].ToString();

                String[] fileLines = File.ReadAllLines(userName + ".txt");
                //29001234

                for (int y = 0; y < 5; y++) // This for loop goes through the text file and splits all the data up by a comma
                {
                    for (int x = 0; x < 9; x++)
                    {
                        slots[y, x] = fileLines[y].Split(',')[x]; // After splitting the data it is added into an array in the same x,y
                        if (slots[y, x].ToString() == "p")
                        {
                            switchYCases(y, x, true);
                        }
                        else if (slots[y, x].ToString() == "e")
                        {
                            switchYCases(y, x, false);                            
                        }


                    }
                }
            }
            prefList.Sort();
            exList.Sort();

            foreach (string item in exList.ToList())
            {
                exlbx.Items.Add(item);
            }
            foreach (string item in prefList.ToList())
            {
                if(exList.Contains(item))
                {
                    prefList.Remove(item);
                }
                else
                { 
                    preflbx.Items.Add(item);
                }

            }

            allAvailable();
        }

        void allAvailable()
        {

            for(int x = 0; x < 5; x++)
            {
                switch (x)
                {
                    case 0:
                        addition("Monday");
                        break;
                    case 1:
                        addition("Tuesday");
                        break;
                    case 2:
                        addition("Wednesday");
                        break;
                    case 3:
                        addition("Thursday");
                        break;
                    case 4:
                        addition("Friday");
                        break;
                }

            }



            foreach(string item in allAvailableList.ToList())
            {
                if(exList.Contains(item))
                {
                    allAvailableList.Remove(item);
                }
                else
                {
                    availablelbx.Items.Add(item);
                }
            }



        }

        void addition(string day)
        {
            allAvailableList.Add(day + " 9am");
            allAvailableList.Add(day + " 10am");
            allAvailableList.Add(day + " 11am");
            allAvailableList.Add(day + " 12pm");
            allAvailableList.Add(day + " 1pm");
            allAvailableList.Add(day + " 2pm");
            allAvailableList.Add(day + " 3pm");
            allAvailableList.Add(day + " 4pm");
            allAvailableList.Add(day + " 5pm");
        }


        void validAddition(bool pref, string day, string time)
        {
            if (pref == true)
            {
                if (!prefList.Contains(day + time))
                {
                    prefList.Add(day + time);
                }
            }
            else
            {
                if (!exList.Contains(day + time))
                {
                    exList.Add(day + time);
                }
            }
        }

        void switchYCases(int y, int x, bool pref)
        {
            switch (y)
                {
                    case 0:
                        addToList(x, "Monday", pref);
                        break;
                    case 1:
                        addToList(x, "Tuesday", pref);
                        break;
                    case 2:
                        addToList(x, "Wednesday", pref);
                        break;
                    case 3:
                        addToList(x, "Thursday", pref);
                        break;
                    case 4:
                        addToList(x, "Friday", pref);
                        break;
                            }
        }

        void addToList(int x, string day, bool pref)
        { 
            switch (x)
            {
                case 0:
                    validAddition(pref, day," 9am");
                    break;
                case 1:
                    validAddition(pref, day, " 10am");
                    break;
                case 2:
                    validAddition(pref, day, " 11am");
                    break;
                case 3:
                    validAddition(pref, day, " 12pm");
                    break;
                case 4:
                    validAddition(pref, day, " 1pm");
                    break;
                case 5:
                    validAddition(pref, day, " 2pm");
                    break;
                case 6:
                    validAddition(pref, day, " 3pm");
                    break;
                case 7:
                    validAddition(pref, day, " 4pm");
                    break;
                case 8:
                    validAddition(pref, day, " 5pm");
                    break;
            }
        }
    }
}