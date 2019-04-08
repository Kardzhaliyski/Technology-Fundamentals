using System;
using System.Linq;
using System.Collections.Generic;

namespace HouseParty
{
    class HouseParty
    {
        static void Main(string[] args)
        {
            int invitationsSent = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int replyRecieved = 0; replyRecieved < invitationsSent; replyRecieved++)
            {
                string[] reply = Console.ReadLine().Split();
                string guestName = reply[0];
                bool isGoing = reply[2] == "going!" ? true : false;

                if (isGoing)
                {
                    AddToList(guestList, guestName);
                }
                else
                {
                    RemoveFromList(guestList, guestName);
                }
            }

            foreach (var name in guestList)
            {
                Console.WriteLine(name);
            }


        }

        private static void RemoveFromList(List<string> guestList, string guestName)
        {
            if (guestList.Contains(guestName))
            {
                guestList.Remove(guestName);
            }
            else
            {
                Console.WriteLine($"{guestName} is not in the list!");
            }
        }

        private static void AddToList(List<string> guestList, string guestName)
        {
            if (guestList.Contains(guestName))
            {
                Console.WriteLine($"{guestName} is already in the list!");
            }
            else
            {
                guestList.Add(guestName);
            }
        }
    }
}
