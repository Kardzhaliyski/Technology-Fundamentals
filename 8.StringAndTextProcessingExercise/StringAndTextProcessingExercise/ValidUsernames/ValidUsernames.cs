using System;

namespace ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            var usernames = Console.ReadLine()
                .Split(", ");
            PrintValidUsernames(usernames);
        }

        public static void PrintValidUsernames(string[] usernames)
        {
            foreach (var username in usernames)
            {
                bool isValid = true;
                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }

                foreach (var character in username)
                {
                    if (char.IsLetterOrDigit(character) == false && character != '-' && character != '_')
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid == false)
                {
                    continue;
                }

                Console.WriteLine(username);
            }
        }
    }
}
