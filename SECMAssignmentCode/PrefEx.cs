using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;



namespace SECMAssignmentCode
{
    public partial class PrefEx : Form
    {
        ComboBox[,] prefArray = new ComboBox[5, 9];
        string[,] userAvailable = new string[5, 9];


        public PrefEx()
        {
            InitializeComponent();
        }

        private void PrefEx_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Drop down lists will appear for you to select when your preferences and exclusions are. If a combo box is not there it means you are already booked into a meeting");
            assignPref();

            loadAvialability();

            validAvailable();





        }


        private void assignPref()
        {
            // Assigns each of the 45 combo boxes into a 8x4 combo box array 
            prefArray[0, 0] = mon09cb;
            prefArray[0, 1] = mon10cb;
            prefArray[0, 2] = mon11cb;
            prefArray[0, 3] = mon12cb;
            prefArray[0, 4] = mon13cb;
            prefArray[0, 5] = mon14cb;
            prefArray[0, 6] = mon15cb;
            prefArray[0, 7] = mon16cb;
            prefArray[0, 8] = mon17cb;


            prefArray[1, 0] = tue09cb;
            prefArray[1, 1] = tue10cb;
            prefArray[1, 2] = tue11cb;
            prefArray[1, 3] = tue12cb;
            prefArray[1, 4] = tue13cb;
            prefArray[1, 5] = tue14cb;
            prefArray[1, 6] = tue15cb;
            prefArray[1, 7] = tue16cb;
            prefArray[1, 8] = tue17cb;


            prefArray[2, 0] = wed09cb;
            prefArray[2, 1] = wed10cb;
            prefArray[2, 2] = wed11cb;
            prefArray[2, 3] = wed12cb;
            prefArray[2, 4] = wed13cb;
            prefArray[2, 5] = wed14cb;
            prefArray[2, 6] = wed15cb;
            prefArray[2, 7] = wed16cb;
            prefArray[2, 8] = wed17cb;

            prefArray[3, 0] = thu09cb;
            prefArray[3, 1] = thu10cb;
            prefArray[3, 2] = thu11cb;
            prefArray[3, 3] = thu12cb;
            prefArray[3, 4] = thu13cb;
            prefArray[3, 5] = thu14cb;
            prefArray[3, 6] = thu15cb;
            prefArray[3, 7] = thu16cb;
            prefArray[3, 8] = thu17cb;


            prefArray[4, 0] = fri09cb;
            prefArray[4, 1] = fri10cb;
            prefArray[4, 2] = fri11cb;
            prefArray[4, 3] = fri12cb;
            prefArray[4, 4] = fri13cb;
            prefArray[4, 5] = fri14cb;
            prefArray[4, 6] = fri15cb;
            prefArray[4, 7] = fri16cb;
            prefArray[4, 8] = fri17cb;
        



        }

        void loadAvialability()
        {
            string fileName = LoginPage.userName + ".txt";

            String[] fileLines = File.ReadAllLines(fileName);

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    userAvailable[y, x] = fileLines[y].Split(',')[x];
                }
            }
        }

        void validAvailable()
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if(userAvailable[y,x] == "b")
                    {
                        prefArray[y,x].Hide();
                    }
                }
            }
        }


        private void savebtn_Click(object sender, EventArgs e)
        {
            string fileName;

            fileName = (LoginPage.userName + ".txt");  // The text file each user's preferences and exclusions are saved is their username

            FileInfo saveData = new FileInfo(fileName);

            if(saveData.Exists)
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
                                if(prefArray[y,x].Visible == false)
                                {
                                    file.Write("b,");
                                }
                                else if (prefArray[y, x].Text == "Prefer") // If the combo box has Prefer selected it will as a "p" to the text file
                                {
                                    file.Write("p,");
                                }
                                else if(prefArray[y, x].Text == "Exclude") // If the combo box has Exclude selected it will as a "e" to the text file
                                {
                                    file.Write("e,");
                                }
                                else // If the combo box has nothing selected or "Don't Mind" there will be a "d" saved to the text file
                                {
                                    file.Write("d,");
                                }

                            }
                            else if (x == 8) // Exactly the same as the if statement above but for the last ekement in a line so there is no "," at the end of each line
                            {
                                if (prefArray[y, x].Visible == false)
                                {
                                    file.Write("b");
                                }
                                else if (prefArray[y, x].Text == "Prefer")
                                {
                                    file.WriteLine("p");
                                }
                                else if (prefArray[y, x].Text == "Exclude")
                                {
                                    file.WriteLine("e");
                                }
                                else
                                {
                                    file.WriteLine("d");
                                }

                            }

                        }

                    }

                



            }



        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPage f3 = new MenuPage();
            f3.Show();



        }
    }
}
