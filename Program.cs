using CarLibrary;
using System;

namespace CodeBaseClient
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** Shared Assembly Client *****");
            _ = new SportsCar();
            Console.WriteLine("Sports car has been allocated.");
            Console.ReadLine();
        }
    }
}
