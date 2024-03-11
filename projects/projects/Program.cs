using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Message myMessage = new Message("Hello World - from Message Object");
            myMessage.Print();

            Console.WriteLine();

            List<Message> messages = new List<Message>(5);
            messages.Add(new Message("Welcome back!"));
            messages.Add(new Message("What a lovely name"));
            messages.Add(new Message("Great name"));
            messages.Add(new Message("Oh hi!"));
            messages.Add(new Message("That is a silly name"));

            string name;
            while (true)
            {
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();

                 if (name.ToLower() == "michael")
                {
                    messages[0].Print();
                }
                else if (name.ToLower() == "mark")
                {
                    messages[1].Print();
                }
                else if (name.ToLower() == "wilma")
                {
                    messages[2].Print();
                }
                else if (name.ToLower() == "alice")
                {
                    messages[3].Print();
                }
                else
                {
                    messages[4].Print();
                }
            }
        }
    }
}


