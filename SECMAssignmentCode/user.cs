using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECMAssignmentCode
{
    class User
    {
        public static string userName, passWord;
        public static int mod;


        public User(string newName, string newPass, int newMod)
        {
            userName = newName;
            passWord = newPass;
            mod = newMod;
        }
    }




}
