using System;

namespace CardDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Hi world!");

            Card aCard = new Card("King", "Queen");
            aCard.PrintDetails();

            aCard.PrintDetails();
            aCard.Flip();
        }
    }
}
