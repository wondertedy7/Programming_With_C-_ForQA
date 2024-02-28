using System.Security.Cryptography;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password ="";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                //char letter = username[i];
                //password += string.Concat(letter);
                 password += username[i];
            }

            string userPass;
            int counter = 0;

            while ((userPass = Console.ReadLine()) != password)
            {
                counter++;

                if (counter == 4)
                {
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }
            if (counter == 4)
            {
                Console.WriteLine($"User {username} blocked!");
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
            }

        }
    }
}