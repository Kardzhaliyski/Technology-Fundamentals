using System;


class Login
{
    static void Main(string[] args)
    {
        string username = Console.ReadLine();
        string password = "";

        for (int i = 0; i < username.Length; i++)
        {
            password += username[username.Length - 1 - i];
        }

        for (int i = 0; i < 4; i++)
        {
            string inputPass = Console.ReadLine();
            if (inputPass == password)
            {
                Console.WriteLine($"User {username} logged in.");
                return;
            }
            else if (i < 3)
            {
                Console.WriteLine("Incorrect password. Try again.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}

