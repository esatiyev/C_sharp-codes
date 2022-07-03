using System;

namespace MyApp
{
    internal class First
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hi,please write your name as user");

            string userName = Console.ReadLine();
            Console.WriteLine("Write your password");
            string password = Console.ReadLine();

            if(userName == "" || password == "")
            {
                while(userName == "") { 
                if(userName == "")
                {
                    Console.WriteLine("Ooh,you didn't write your username.Please,write!!!");
                    userName = Console.ReadLine();
                }
                }
                while(password == "") { 
                if (password == "")
                {
                    Console.WriteLine("Ooh,you didn't write your password.Please,write!!!");
                    password = Console.ReadLine();
                }

                }

            }

            Console.WriteLine("You join our website.Please login in.Write your User Name:");
            string loggedName = Console.ReadLine();
            Console.WriteLine("Write your password");
            string loggedPassword = Console.ReadLine();

            if(loggedName != userName || loggedPassword != password)
            {
                while(loggedName != userName || loggedPassword != password) 
                { 
                Console.WriteLine("Username or password is incorrect!!!");
                Console.WriteLine("Please,write your username and password");
                loggedName = Console.ReadLine();
                loggedPassword = Console.ReadLine();
                }
            }

            if(loggedName == userName && loggedPassword == password)
            {
                Console.WriteLine("Hi,{0}.You are already login in.", userName);
            }

            Console.ReadKey();
        }
       
        
    }
}
