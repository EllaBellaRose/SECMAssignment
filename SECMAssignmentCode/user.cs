using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECMAssignmentCode
{
    public class User
    {
        public static List<User> userList;
        public string userName, passWord;
        public bool mod;
        //public static List<Meeting> inMeetings;


        public User(string newName, string newPass, int newMod)
        {
            userName = newName;
            passWord = newPass;
            if(newMod == 1)
            {
                mod = true;
            }
            else
            {
                mod = false;
            }
 
        }

        public void setUserName(string newName)
        {
            userName = newName;
        }
        public void setPassword(string newPass)
        {
            passWord = newPass;
        }
        public void setMod(int newMod)
        {
            if (newMod == 1)
            {
                mod = true;
            }
            else
            {
                mod = false;
            }
        }

        public string getUserName()
        {
            return userName;
        }
        public string getPassword()
        {
            return passWord;
        }
        public bool getMod()
        {
            return mod;
        }

    }




}
