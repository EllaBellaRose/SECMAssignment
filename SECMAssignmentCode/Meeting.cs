using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECMAssignmentCode
{
    class Meeting
    {
        public static int day, time, room;
        public static List<User> members = new List<User>();

        public Meeting(string newDay, int newTime)
        {
            setDay(newDay);
            time = newTime;
        }

        public void addUser(User member)
        {
            members.Add(member);
        }

        public void setDay(string newDay)
        {
            switch(newDay)
            {
                case "Monday":
                    day = 0;
                    break;
                case "Tuesday":
                    day = 1;
                    break;
                case "Wednesday":
                    day = 2;
                    break;
                case "Thursday":
                    day = 3;
                    break;
                case "Friday":
                    day = 4;
                    break;
                default:
                    day = 0;
                    break;
            }

        }

        public string getDay()
        {
            switch (day)
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

        public void setTime(int newTime)
        {
            time = newTime;
        }

        public int getTime()
        {
            return time;
        }

        public void setRoom(int newRoom)
        {
            room = newRoom;
        }

        public int getRoom()
        {
            return room;
        }
    }
}
