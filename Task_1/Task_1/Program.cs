using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salam, ashagidaki melumatlari daxil edin.");
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            User user = new User();  // teze user yaratdim, username ve password verdim 

            user.Username = username;
            user.Password = password;

            Console.WriteLine(user.GetFullName());

            //string word = "09 AZ az";   // spacein ascii si 32 di
            //foreach (char item in word)
            //{
            //    Console.WriteLine((int)item);
            //}

        }
    }
}
